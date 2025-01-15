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
            SuspendLayout();
            // 
            // userTextBox
            // 
            userTextBox.Location = new Point(280, 143);
            userTextBox.Name = "userTextBox";
            userTextBox.PlaceholderText = "Input username";
            userTextBox.Size = new Size(230, 27);
            userTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(280, 199);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Input password";
            passwordTextBox.Size = new Size(230, 27);
            passwordTextBox.TabIndex = 1;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(280, 256);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(103, 29);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(407, 256);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(103, 29);
            registerBtn.TabIndex = 3;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(registerBtn);
            Controls.Add(loginBtn);
            Controls.Add(passwordTextBox);
            Controls.Add(userTextBox);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userTextBox;
        private TextBox passwordTextBox;
        private Button loginBtn;
        private Button registerBtn;
    }
}