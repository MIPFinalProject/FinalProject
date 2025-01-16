namespace Proiect2
{
    partial class StergereCategorieForm
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(113, 129);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 132);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Categorie";
            // 
            // button1
            // 
            button1.Location = new Point(66, 167);
            button1.Name = "button1";
            button1.Size = new Size(158, 23);
            button1.TabIndex = 2;
            button1.Text = "Sterge categorie";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // StergereCategorieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 304);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "StergereCategorieForm";
            Text = "StergereCategorieForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
    }
}