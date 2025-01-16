using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using LoggingLibrary;
using Proiect2.DTO;
using Proiect2.Entity;
using Proiect2.Localization;
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

            button1.Text = LocalizationManager.GetString("ExportSalesToXML");

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

            TranslateColumnHeaders();
        }

        private void TranslateColumnHeaders()
        {

            if (dataGridView1.Columns["ProductId"] != null)
                dataGridView1.Columns["ProductId"].HeaderText = LocalizationManager.GetString("ProductId");

            if (dataGridView1.Columns["ProductName"] != null)
                dataGridView1.Columns["ProductName"].HeaderText = LocalizationManager.GetString("Name");

            if (dataGridView1.Columns["CategoryName"] != null)
                dataGridView1.Columns["CategoryName"].HeaderText = LocalizationManager.GetString("CategoryName");

            if (dataGridView1.Columns["Quantity"] != null)
                dataGridView1.Columns["Quantity"].HeaderText = LocalizationManager.GetString("Quantity");
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "SalesHistory.xml";

                var xmlDoc = new XDocument(
                    new XElement("SalesHistory",
                        _fullSalesHistory.Select(sale => new XElement("Sale",
                            new XElement("Id", sale.Id),
                            new XElement("ProductId", sale.ProductId),
                            new XElement("ProductName", sale.ProductName),
                            new XElement("CategoryName", sale.CategoryName),
                            new XElement("Quantity", sale.Quantity)
                        ))
                    )
                );

                xmlDoc.Save(filePath);

                MessageBox.Show($"Datele au fost exportate cu succes în {filePath}.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TraceLogger.LogInfo("Data exported to XML successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la exportul datelor: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TraceLogger.LogError("Error when trying to export data");
            }
        }

    }
}
