namespace Database_B_tree
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 41);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 23;
            label7.Text = "Index here";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 212);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 22;
            label6.Text = "File accesses:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 172);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 21;
            label5.Text = "Place:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(49, 335);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(184, 93);
            textBox3.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(49, 282);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(184, 27);
            textBox2.TabIndex = 19;
            // 
            // button2
            // 
            button2.Location = new Point(173, 12);
            button2.Name = "button2";
            button2.Size = new Size(60, 49);
            button2.TabIndex = 18;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 192);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 17;
            label4.Text = "File accesses:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 259);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 16;
            label3.Text = "Index:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 312);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 15;
            label2.Text = "Text";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 152);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 14;
            label1.Text = "Place:";
            // 
            // button1
            // 
            button1.Location = new Point(49, 100);
            button1.Name = "button1";
            button1.Size = new Size(184, 49);
            button1.TabIndex = 13;
            button1.Text = "Find in database";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(50, 67);
            numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 24;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "Form3";
            FormClosing += Form3_FormClosing;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private NumericUpDown numericUpDown1;
    }
}