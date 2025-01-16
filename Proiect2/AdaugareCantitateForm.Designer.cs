namespace Proiect2
{
    partial class AdaugareCantitateForm
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
            label2 = new Label();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 128);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Id produs";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 166);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Cantitate";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(222, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(83, 23);
            textBox1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(221, 164);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(79, 23);
            numericUpDown1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(173, 203);
            button1.Name = "button1";
            button1.Size = new Size(127, 23);
            button1.TabIndex = 4;
            button1.Text = "Adauga cantitate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AdaugareCantitateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 347);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdaugareCantitateForm";
            Text = "AdaugareCantitateForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private Button button1;
    }
}