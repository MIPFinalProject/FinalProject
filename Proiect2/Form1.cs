using Proiect2.Data;
using Proiect2.DTO;
using Proiect2.Entity;
using Proiect2.Repository;
using Proiect2.Service;

namespace Proiect2
{
    public partial class Form1 : Form
    {
        private readonly ProductService _productService;
        private readonly ProductCategoryService _productCategoryService;
        private readonly SalesHistoryService _salesHistoryService;

        public Form1()
        {
            InitializeComponent();

            var context = DbContextFactory.CreateDbContext();
            var repository = new ProductRepository(context);
            _productService = new ProductService(repository);

            var productCategoryRepository = new ProductCategoryRepository(context);
            _productCategoryService = new ProductCategoryService(productCategoryRepository);

            var salesHistoryRepository = new SalesHistoryRepository(context);
            _salesHistoryService = new SalesHistoryService(salesHistoryRepository);

            LoadProductsAsync();
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
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
    }

}
