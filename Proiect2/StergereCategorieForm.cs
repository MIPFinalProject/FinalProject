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
using Proiect2.Localization;
using Proiect2.Service;

namespace Proiect2
{
    public partial class StergereCategorieForm : Form
    {
        private readonly ProductCategoryService _categoryService;
        public StergereCategorieForm(ProductCategoryService productCategory)
        {
            InitializeComponent();

            label1.Text = LocalizationManager.GetString("Category");
            button1.Text = LocalizationManager.GetString("DeleteCategory");

            _categoryService = productCategory;
            LoadCategoriesAsync();
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
            await _categoryService.DeleteProductCategory((int)comboBox1.SelectedValue);
            MessageBox.Show("Categorie stearsa cu succes!", "Confirmare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TraceLogger.LogInfo("Category deleted successfully");
            LoadCategoriesAsync();
        }
    }
}
