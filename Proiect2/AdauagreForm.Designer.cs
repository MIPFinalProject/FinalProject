namespace Proiect2
{
    partial class AdauagreForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            button2 = new Button();
            label6 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(249, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(249, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 23);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 97);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Nume";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 126);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 5;
            label2.Text = "Descriere";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 155);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 6;
            label3.Text = "Data intrarii";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(249, 152);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(175, 184);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 8;
            label4.Text = "Data expirarii";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(256, 181);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(256, 212);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(188, 214);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 11;
            label5.Text = "Cantitate";
            // 
            // button2
            // 
            button2.Location = new Point(188, 284);
            button2.Name = "button2";
            button2.Size = new Size(177, 23);
            button2.TabIndex = 13;
            button2.Text = "Adauga produs";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(152, 247);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 14;
            label6.Text = "Categorie produs";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(256, 244);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 15;
            // 
            // AdauagreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 426);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker2);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "AdauagreForm";
            Text = "AdauagreForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private Button button2;
        private Label label6;
        private ComboBox comboBox1;
    }
}