using System;
using System.Windows.Forms;
using Proiect2.Data;
using Proiect2.Localization;
using Proiect2.Repository;
using Proiect2.Service;
using LoggingLibrary;
using Proiect2.Entity;

namespace Proiect2
{
    public partial class LoginForm : Form
    {
        private readonly ProductService _productService;
        private readonly ProductCategoryService _productCategoryService;
        private readonly SalesHistoryService _salesHistoryService;
        private readonly UserService _userService;

        public LoginForm()
        {
            InitializeComponent();

            loginBtn.Text = LocalizationManager.GetString("Login");
            registerBtn.Text = LocalizationManager.GetString("Register");

            var context = DbContextFactory.CreateDbContext();

            var productRepository = new ProductRepository(context);
            _productService = new ProductService(productRepository);

            var productCategoryRepository = new ProductCategoryRepository(context);
            _productCategoryService = new ProductCategoryService(productCategoryRepository);

            var salesHistoryRepository = new SalesHistoryRepository(context);
            _salesHistoryService = new SalesHistoryService(salesHistoryRepository);

            var userRepository = new UserRepository(context);
            _userService = new UserService(userRepository);
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            string username = userTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            try
            {
                User user = await _userService.AuthenticateUser(username, password);
                TraceLogger.LogInfo("Authentification successfully");

                using (var form = new Form1(_productService, _salesHistoryService, _productCategoryService, _userService, user))
                {
                    this.Hide();
                    form.ShowDialog();
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                TraceLogger.LogInfo("Failed to logIn");
                MessageBox.Show("Authentication failed: " + ex.Message);
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            TraceLogger.LogInfo("Register button clicked");
            using (var form = new RegisterForm(_userService))
            {
                form.ShowDialog();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LocalizationManager.SetLanguage("ro");
            ApplyTranslations();
            TraceLogger.LogInfo("Language set to RO");
            MessageBox.Show("Language set to RO", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            LocalizationManager.SetLanguage("en");
            ApplyTranslations();
            TraceLogger.LogInfo("Language set to EN");
            MessageBox.Show("Language set to EN", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ApplyTranslations()
        {
            loginBtn.Text = LocalizationManager.GetString("Login");
            registerBtn.Text = LocalizationManager.GetString("Register");
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new ModifyPasswordForm(_userService))
            {
                form.ShowDialog();
            }
        }
    }
}