namespace Proiect2
{
    partial class AdaugareCategorieForm
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 172);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "Nume categorie";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(163, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(76, 210);
            button1.Name = "button1";
            button1.Size = new Size(193, 23);
            button1.TabIndex = 2;
            button1.Text = "Adauga categorie";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AdaugareCategorieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 359);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "AdaugareCategorieForm";
            Text = "AdaugareCategorieForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
    }
}