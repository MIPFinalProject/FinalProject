using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect2.Service;
namespace Proiect2
{
    public partial class UserManagementForm : Form
    {
        private readonly UserService _userService;
        public UserManagementForm(UserService userService)
        {
            _userService = userService;
            InitializeComponent();
            LoadUsers();
            InitializeContextMenu();
        }
        private async void LoadUsers()
        {
            try
            {
                var users = await _userService.GetAllUsers();
                dataGridView1.DataSource = users;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load users: " + ex.Message);
            }
        }
        private void InitializeContextMenu()
        {
            var contextMenu = new ContextMenuStrip();
            var deleteMenuItem = new ToolStripMenuItem("Delete User", null, DeleteUserMenuItem_Click);
            contextMenu.Items.Add(deleteMenuItem);
            dataGridView1.ContextMenuStrip = contextMenu;
        }
        private async void DeleteUserMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int userId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                var confirmResult = MessageBox.Show("Are you sure to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        await _userService.DeleteUser(userId);
                        MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUsers();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to delete user: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dataGridView1.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[hitTestInfo.RowIndex].Selected = true;
                }
            }
        }
    }
}