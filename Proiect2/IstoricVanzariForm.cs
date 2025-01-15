using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect2.DTO;
using Proiect2.Entity;
using Proiect2.Service;

namespace Proiect2
{
    public partial class IstoricVanzariForm : Form
    {
        private readonly SalesHistoryService _salesHistoryService;
        private readonly ProductService _productService;
        private readonly ProductCategoryService _productCategoryService;
        private List<SaleHistoryDto> _fullSalesHistory;

        public IstoricVanzariForm(SalesHistoryService salesHistoryService, ProductService productService, ProductCategoryService productCategoryService)
        {
            InitializeComponent();
            _salesHistoryService = salesHistoryService;
            _productService = productService;
            _productCategoryService = productCategoryService;

            LoadSalesHistoryAsync();
        }

        private async Task LoadSalesHistoryAsync()
        {
            var sales = await _salesHistoryService.GetAll();
            var products = await _productService.GetAllProducts();
            var categories = await _productCategoryService.GetAllProductCategories();

            _fullSalesHistory = new List<SaleHistoryDto>();

            foreach (SalesHistory sale in sales)
            {
                Product product = products.FirstOrDefault(p => p.Id == sale.ProductId);
                if (product == null)
                {
                    continue;
                }
                SaleHistoryDto newSale = new SaleHistoryDto
                {
                    Id = sale.Id,
                    ProductId = sale.ProductId,
                    Quantity = sale.Quantity,
                    ProductName = product.Name,
                    CategoryName = categories.FirstOrDefault(cat => cat.Id == product.CategoryId)?.Name ?? "N/A"
                };
                _fullSalesHistory.Add(newSale);
            }

            dataGridView1.DataSource = _fullSalesHistory;
        }

        private void FilterSalesHistory(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                dataGridView1.DataSource = _fullSalesHistory;
            }
            else if (int.TryParse(searchText, out int saleId))
            {
                var filteredList = _fullSalesHistory.Where(sale => sale.Id == saleId).ToList();
                dataGridView1.DataSource = filteredList;
            }
            else
            {
                dataGridView1.DataSource = new List<SaleHistoryDto>();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;
            FilterSalesHistory(searchText);
        }
    }
}
