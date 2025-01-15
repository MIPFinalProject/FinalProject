namespace Proiect2
{
    partial class RegisterForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            registerBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(290, 138);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Input username";
            textBox1.Size = new Size(227, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(290, 186);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Input password";
            textBox2.Size = new Size(227, 27);
            textBox2.TabIndex = 1;
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(290, 232);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(227, 29);
            registerBtn.TabIndex = 2;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(290, 282);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(227, 29);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelBtn);
            Controls.Add(registerBtn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button registerBtn;
        private Button cancelBtn;
    }
}