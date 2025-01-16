using System;
using System.Windows.Forms;
using Proiect2.Service;
namespace Proiect2
{
    public partial class ModifyPasswordForm : Form
    {
        private readonly UserService _userService;
        public ModifyPasswordForm(UserService userService)
        {
            _userService = userService;
            InitializeComponent();
        }
        private async void changePasswordBtn_Click(object sender, EventArgs e)
        {
            string username = userTextBox.Text.Trim();
            string oldPassword = passwordTextBox.Text.Trim();
            string newUsername = newUserTextBox.Text.Trim();
            string newPassword = newPasswordTextBox.Text.Trim();
            try
            {
                await _userService.ChangeUsernameAndPassword(username, oldPassword, newUsername, newPassword);
                MessageBox.Show("Username and/or password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to change username and/or password: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}