namespace Proiect2
{
    partial class LoginForm
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
            userTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginBtn = new Button();
            registerBtn = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            changePasswordBtn = new Button();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // userTextBox
            // 
            userTextBox.Location = new Point(245, 107);
            userTextBox.Margin = new Padding(3, 2, 3, 2);
            userTextBox.Name = "userTextBox";
            userTextBox.PlaceholderText = "Input username";
            userTextBox.Size = new Size(202, 23);
            userTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(245, 149);
            passwordTextBox.Margin = new Padding(3, 2, 3, 2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Input password";
            passwordTextBox.Size = new Size(202, 23);
            passwordTextBox.TabIndex = 1;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(245, 192);
            loginBtn.Margin = new Padding(3, 2, 3, 2);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(90, 22);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(356, 192);
            registerBtn.Margin = new Padding(3, 2, 3, 2);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(90, 22);
            registerBtn.TabIndex = 3;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(700, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(71, 20);
            toolStripMenuItem1.Text = "Language";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(90, 22);
            toolStripMenuItem2.Text = "RO";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(90, 22);
            toolStripMenuItem3.Text = "EN";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // changePasswordBtn
            // 
            changePasswordBtn.Location = new Point(12, 410);
            changePasswordBtn.Name = "changePasswordBtn";
            changePasswordBtn.Size = new Size(158, 29);
            changePasswordBtn.TabIndex = 5;
            changePasswordBtn.Text = "Change Password";
            changePasswordBtn.UseVisualStyleBackColor = true;
            changePasswordBtn.Click += changePasswordBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(30, 293);
            button1.Name = "button1";
            button1.Size = new Size(186, 23);
            button1.TabIndex = 6;
            button1.Text = "Change password | User";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(button1);
            Controls.Add(changePasswordBtn);
            Controls.Add(registerBtn);
            Controls.Add(loginBtn);
            Controls.Add(passwordTextBox);
            Controls.Add(userTextBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            Text = "LoginForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userTextBox;
        private TextBox passwordTextBox;
        private Button loginBtn;
        private Button registerBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private Button changePasswordBtn;
        private Button button1;
    }
}