using LoggingLibrary;
using Proiect2.Data;
using Proiect2.DTO;
using Proiect2.Entity;
using Proiect2.Localization;
using Proiect2.Repository;
using Proiect2.Service;

namespace Proiect2
{
    public partial class Form1 : Form
    {
        private readonly ProductService _productService;
        private readonly ProductCategoryService _productCategoryService;
        private readonly SalesHistoryService _salesHistoryService;
        private readonly UserService _userService;
        private readonly User _currentUser;

        public Form1(ProductService productService, SalesHistoryService salesHistoryService, ProductCategoryService productCategoryService, UserService userService, User currentUser)
        {
            _productService = productService;
            _salesHistoryService = salesHistoryService;
            _productCategoryService = productCategoryService;
            _userService = userService;
            _currentUser = currentUser;
            InitializeComponent();

            if (_currentUser.Role != "admin")
            {
                HideMenuItems();
                DisableProductDeletionAndUpdate();
            }

            button1.Text = LocalizationManager.GetString("Refresh");
            toolStripMenuItem1.Text = LocalizationManager.GetString("AddProducts");
            toolStripMenuItem2.Text = LocalizationManager.GetString("AddCategory");
            toolStripMenuItem8.Text = LocalizationManager.GetString("DeleteCategory");
            toolStripMenuItem3.Text = LocalizationManager.GetString("SalesHistory");
            toolStripMenuItem4.Text = LocalizationManager.GetString("AddNewProduct");
            toolStripMenuItem5.Text = LocalizationManager.GetString("AddQuantity");
            toolStripMenuItem6.Text = LocalizationManager.GetString("Delete");
            toolStripMenuItem7.Text = LocalizationManager.GetString("UpdateProduct");
        }

        private void HideMenuItems()
        {
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.Visible = false;
            }
        }
        private void DisableProductDeletionAndUpdate()
        {
            toolStripMenuItem6.Visible = false;
            toolStripMenuItem7.Visible = false;
        }

        private async Task LoadProductsAsync()
        {
            TraceLogger.LogInfo("Load products successfully");
            var products = await _productService.GetAllProducts();
            var categories = await _productCategoryService.GetAllProductCategories();

            var categoryDict = categories.ToDictionary(c => c.Id, c => c.Name);

            var productsWithCategories = products.Select(p => new ProductWithCategoryDto
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                EntryDate = p.EntryDate,
                ExpiryDate = p.ExpiryDate,
                Quantity = p.Quantity,
                CategoryName = categoryDict.ContainsKey(p.CategoryId) ? categoryDict[p.CategoryId] : "N/A"
            }).ToList();

            dataGridView1.DataSource = productsWithCategories;

            TranslateColumnHeaders();
        }

        private void TranslateColumnHeaders()
        {
            dataGridView1.Columns["Name"].HeaderText = LocalizationManager.GetString("Name");
            dataGridView1.Columns["Description"].HeaderText = LocalizationManager.GetString("Description");
            dataGridView1.Columns["EntryDate"].HeaderText = LocalizationManager.GetString("EntryDate");
            dataGridView1.Columns["ExpiryDate"].HeaderText = LocalizationManager.GetString("ExpiryDate");
            dataGridView1.Columns["Quantity"].HeaderText = LocalizationManager.GetString("Quantity");
            dataGridView1.Columns["CategoryName"].HeaderText = LocalizationManager.GetString("CategoryName");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            TraceLogger.LogInfo("Refresh button clicked");
            await LoadProductsAsync();
        }

        private async void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                int id = Convert.ToInt32(row.Cells["Id"].Value);
                Product product = await _productService.GetProductById(id);

                TraceLogger.LogInfo("Opening sale product page");

                using (VanzareForm form = new VanzareForm(_productService, _salesHistoryService, product))
                {
                    form.ShowDialog();
                }
            }
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.ToLower();

            var products = await _productService.GetAllProducts();

            var filteredProducts = products
                .Where(product => product.Name.ToLower().Contains(searchText))
                .ToList();

            dataGridView1.DataSource = filteredProducts;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            TraceLogger.LogInfo("Opening add product form");
            using (AdauagreForm form = new AdauagreForm(_productService, _productCategoryService))
            {
                form.ShowDialog();
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            TraceLogger.LogInfo("Opening add product quantity form");
            using (AdaugareCantitateForm form = new AdaugareCantitateForm(_productService))
            {
                form.ShowDialog();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TraceLogger.LogInfo("Opening add product category form");
            using (AdaugareCategorieForm form = new AdaugareCategorieForm(_productCategoryService))
            {
                form.ShowDialog();
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TraceLogger.LogInfo("Opening product sales history form");
            using (IstoricVanzariForm form = new IstoricVanzariForm(_salesHistoryService, _productService, _productCategoryService))
            {
                form.ShowDialog();
            }
        }

        private async void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                TraceLogger.LogInfo("Delete product successfully");
                var selectedRow = dataGridView1.SelectedRows[0];
                int productId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                await _productService.DeleteProduct(productId);
                MessageBox.Show("Produs sters cu succes!", "Confirmare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dataGridView1.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[hitTestInfo.RowIndex].Selected = true;
                }
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int productId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                TraceLogger.LogInfo("Opening update product form");

                using (UpdateProduct form = new UpdateProduct(_productService, productId, _productCategoryService))
                {
                    form.ShowDialog();
                }
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            TraceLogger.LogInfo("Opening delete product category form");
            using (StergereCategorieForm form = new StergereCategorieForm(_productCategoryService))
            {
                form.ShowDialog();
            }
        }

        private void usersToolStripMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            using (UserManagementForm form = new UserManagementForm(_userService))
            {
                form.ShowDialog();
            }

        }
    }

}
