using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect2.Entity;
using Proiect2.Service;

namespace Proiect2
{
    public partial class AdaugareCategorieForm : Form
    {
        private readonly ProductCategoryService _productCategoryService;

        public AdaugareCategorieForm(ProductCategoryService productCategoryService)
        {
            InitializeComponent();
            _productCategoryService = productCategoryService;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            ProductCategory productCategory = new ProductCategory
            {
                Name = textBox1.Text
            };

            if (string.IsNullOrWhiteSpace(productCategory.Name))
            {
                MessageBox.Show("Numele categoriei este obligatoriu!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await _productCategoryService.AddProductCategory(productCategory);
            MessageBox.Show("Categorie adaugata cu succes!", "Confirmare", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
