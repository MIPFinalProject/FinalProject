using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect2.Service;

namespace Proiect2
{
    public partial class AdaugareCantitateForm : Form
    {
        private readonly ProductService _productService;

        public AdaugareCantitateForm(ProductService productService)
        {
            InitializeComponent();
            _productService = productService;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if ((int)numericUpDown1.Value > 0 && !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                int productId = Int32.Parse(textBox1.Text);
                try
                {
                    await _productService.AddProductQuantity(productId, (int)numericUpDown1.Value);
                    MessageBox.Show("Cantitate adaugata cu succes", "Confirmare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Date insuficiente", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
