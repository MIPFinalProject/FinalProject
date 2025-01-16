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
using Proiect2.Service;

namespace Proiect2
{
    public partial class VanzareForm : Form
    {
        private readonly ProductService _productService;
        private readonly SalesHistoryService _salesHistoryService;
        private Product _sellProduct;

        public VanzareForm(ProductService productService, SalesHistoryService salesHistoryService, Product sellProduct)
        {
            InitializeComponent();
            _productService = productService;
            _salesHistoryService = salesHistoryService;
            _sellProduct = sellProduct;

            textBox1.Text = _sellProduct.Id.ToString();
            textBox2.Text = _sellProduct.Name;
            textBox3.Text = _sellProduct.Description;
            textBox4.Text = _sellProduct.EntryDate.ToString();
            textBox5.Text = _sellProduct.ExpiryDate.ToString();
            textBox6.Text = _sellProduct.Quantity.ToString();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if ((int)numericUpDown1.Value == 0)
            {
                MessageBox.Show("Cantitate insuficienta!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TraceLogger.LogError("Insufficient quantity");
            }
            else if ((int)numericUpDown1.Value > _sellProduct.Quantity)
            {
                MessageBox.Show("Cantitate indisponibila!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TraceLogger.LogError("Quantity unavailable");
            }
            else
            {
                _sellProduct.Quantity -= (int)numericUpDown1.Value;

                SalesHistory sale = new SalesHistory
                {
                    ProductId = _sellProduct.Id,
                    Quantity = (int)numericUpDown1.Value
                };
                await _salesHistoryService.Add(sale);

                if (_sellProduct.Quantity == 0)
                {
                    await _productService.DeleteProduct(_sellProduct.Id);
                    MessageBox.Show("Vanzare efectuata cu succes!", "Confirmare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TraceLogger.LogInfo("Sale made successfully");
                    Close();
                }
                else
                {
                    await _productService.SellProduct(_sellProduct);
                    textBox6.Text = _sellProduct.Quantity.ToString();
                    TraceLogger.LogInfo("Sale made successfully");
                    MessageBox.Show("Vanzare efectuata cu succes!", "Confirmare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }

}
