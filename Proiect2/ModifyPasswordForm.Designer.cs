namespace Proiect2
{
    partial class ModifyPasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            passwordTextBox = new TextBox();
            userTextBox = new TextBox();
            newPasswordTextBox = new TextBox();
            changePasswordBtn = new Button();
            cancelBtn = new Button();
            newUserTextBox = new TextBox();
            SuspendLayout();
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(279, 218);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Input old password";
            passwordTextBox.Size = new Size(230, 27);
            passwordTextBox.TabIndex = 3;
            // 
            // userTextBox
            // 
            userTextBox.Location = new Point(279, 110);
            userTextBox.Name = "userTextBox";
            userTextBox.PlaceholderText = "Input username";
            userTextBox.Size = new Size(230, 27);
            userTextBox.TabIndex = 2;
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Location = new Point(281, 269);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.PlaceholderText = "Input new password";
            newPasswordTextBox.Size = new Size(230, 27);
            newPasswordTextBox.TabIndex = 4;
            // 
            // changePasswordBtn
            // 
            changePasswordBtn.Location = new Point(279, 331);
            changePasswordBtn.Name = "changePasswordBtn";
            changePasswordBtn.Size = new Size(102, 29);
            changePasswordBtn.TabIndex = 5;
            changePasswordBtn.Text = "Update";
            changePasswordBtn.UseVisualStyleBackColor = true;
            changePasswordBtn.Click += changePasswordBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(409, 331);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(102, 29);
            cancelBtn.TabIndex = 6;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // newUserTextBox
            // 
            newUserTextBox.Location = new Point(279, 165);
            newUserTextBox.Name = "newUserTextBox";
            newUserTextBox.PlaceholderText = "Input new username(if desired)";
            newUserTextBox.Size = new Size(230, 27);
            newUserTextBox.TabIndex = 7;
            // 
            // ModifyPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(newUserTextBox);
            Controls.Add(cancelBtn);
            Controls.Add(changePasswordBtn);
            Controls.Add(newPasswordTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(userTextBox);
            Name = "ModifyPasswordForm";
            Text = "ModifyPasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private TextBox passwordTextBox;
        private TextBox userTextBox;
        private TextBox newPasswordTextBox;
        private Button changePasswordBtn;
        private Button cancelBtn;
        private TextBox newUserTextBox;
    }
}