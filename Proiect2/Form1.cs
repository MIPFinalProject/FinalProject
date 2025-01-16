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

        public Form1(ProductService productService, SalesHistoryService salesHistoryService, ProductCategoryService productCategoryService, UserService userService)
        {
            _productService = productService;
            _salesHistoryService = salesHistoryService;
            _productCategoryService = productCategoryService;
            _userService = userService;
            InitializeComponent();

            button1.Text = LocalizationManager.GetString("LabelOK");
        }

        private async Task LoadProductsAsync()
        {
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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await LoadProductsAsync();
        }

        private async void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                int id = Convert.ToInt32(row.Cells["Id"].Value);
                Product product = await _productService.GetProductById(id);

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
            using (AdauagreForm form = new AdauagreForm(_productService, _productCategoryService))
            {
                form.ShowDialog();
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            using (AdaugareCantitateForm form = new AdaugareCantitateForm(_productService))
            {
                form.ShowDialog();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            using (AdaugareCategorieForm form = new AdaugareCategorieForm(_productCategoryService))
            {
                form.ShowDialog();
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            using (IstoricVanzariForm form = new IstoricVanzariForm(_salesHistoryService, _productService, _productCategoryService))
            {
                form.ShowDialog();
            }
        }

        private async void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
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

                using (UpdateProduct form = new UpdateProduct(_productService, productId, _productCategoryService))
                {
                    form.ShowDialog();
                }
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            using (StergereCategorieForm form = new StergereCategorieForm(_productCategoryService))
            {
                form.ShowDialog();
            }
        }
    }

}
