using System;
using System.Diagnostics;
using System.Windows.Forms;
using LoggingLibrary;
using Proiect2.Entity;
using Proiect2.Localization;
using Proiect2.Service;

namespace Proiect2
{
    public partial class RegisterForm : Form
    {
        private readonly UserService _userService;

        public RegisterForm(UserService userService)
        {
            InitializeComponent();

            registerBtn.Text = LocalizationManager.GetString("Register");
            cancelBtn.Text = LocalizationManager.GetString("Cancel");

            _userService = userService;
        }

        private async void registerBtn_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields");
                Trace.WriteLine("User register error: Username or Password is empty");
                return;
            }

            var user = new User
            {
                Username = username,
                Password = password,
                Role = "user"
            };

            try
            {
                Trace.WriteLine("Attempting to add user: " + username);
                await _userService.AddUser(user);
                MessageBox.Show("User registered successfully");
                Trace.WriteLine("User registered successfully: " + username);
                this.Close();
                TraceLogger.LogInfo("Register successfully");
            }
            catch (Exception ex)
            {
                TraceLogger.LogError("Errror occured when trying to register");
                MessageBox.Show("Error creating user: " + ex.Message);
                Trace.WriteLine("Error creating user: " + ex.Message);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            TraceLogger.LogInfo("Cancel button clicked");
            this.Close();
        }
    }
}