namespace Proiect2
{
    partial class UpdateProduct
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 249);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 23;
            label6.Text = "Cantitate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 210);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 22;
            label5.Text = "Data expirare";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 173);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 21;
            label4.Text = "Data intrare";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 131);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 20;
            label3.Text = "Descriere";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 92);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 19;
            label2.Text = "Nume";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 64);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 18;
            label1.Text = "Id";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(78, 128);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(78, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(78, 61);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(78, 23);
            textBox1.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(32, 327);
            button1.Name = "button1";
            button1.Size = new Size(189, 23);
            button1.TabIndex = 25;
            button1.Text = "Update product";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(99, 173);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 26;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(98, 210);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 27;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(78, 247);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 28;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(81, 276);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 279);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 30;
            label7.Text = "Categorie";
            // 
            // UpdateProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "UpdateProduct";
            Text = "UpdateProduct";
            Load += UpdateProduct_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private Label label7;
    }
}