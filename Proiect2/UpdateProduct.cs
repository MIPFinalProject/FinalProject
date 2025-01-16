using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoggingLibrary;
using Proiect2.Entity;
using Proiect2.Localization;
using Proiect2.Service;

namespace Proiect2
{
    public partial class UpdateProduct : Form
    {
        private readonly ProductService _productService;
        private readonly ProductCategoryService _categoryService;
        private readonly int _productId;
        public UpdateProduct(ProductService productService, int productId, ProductCategoryService productCategoryService)
        {
            InitializeComponent();

            label2.Text = LocalizationManager.GetString("Name");
            label3.Text = LocalizationManager.GetString("Description");
            label4.Text = LocalizationManager.GetString("EntryDate");
            label5.Text = LocalizationManager.GetString("ExpiryDate");
            label6.Text = LocalizationManager.GetString("Quantity");
            label7.Text = LocalizationManager.GetString("Category");
            button1.Text = LocalizationManager.GetString("UpdateProduct");

            _productService = productService;
            _productId = productId;
            _categoryService = productCategoryService;
        }

        private async void UpdateProduct_Load(object sender, EventArgs e)
        {
            Product product = await _productService.GetProductById(_productId);
            if (product != null)
            {
                textBox1.Text = product.Id.ToString();
                textBox2.Text = product.Name.ToString();
                textBox3.Text = product.Description.ToString();
                dateTimePicker1.Value = product.ExpiryDate;
                dateTimePicker2.Value = product.ExpiryDate;
                numericUpDown1.Value = product.Quantity;
                await LoadCategoriesAsync();
            }
        }

        private async Task LoadCategoriesAsync()
        {
            var categories = await _categoryService.GetAllProductCategories();
            comboBox1.DataSource = categories;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Product product = await _productService.GetProductById(_productId);
            product.Id = int.Parse(textBox1.Text);
            product.Name = textBox2.Text;
            product.Description = textBox3.Text;
            product.EntryDate = dateTimePicker1.Value;
            product.ExpiryDate = dateTimePicker2.Value;
            product.Quantity = (int)numericUpDown1.Value;
            product.CategoryId = (int)comboBox1.SelectedValue;
            await _productService.UpdateProduct(product);
            MessageBox.Show("Produs actualizat cu succes!", "Confirmare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TraceLogger.LogInfo("Product updated successfully");
        }
    }
}
