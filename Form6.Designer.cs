namespace Database_B_tree
{
    partial class Form6
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
            label7 = new Label();
            label6 = new Label();
            button2 = new Button();
            label4 = new Label();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(308, 120);
            label7.Name = "label7";
            label7.Size = new Size(135, 20);
            label7.TabIndex = 25;
            label7.Text = "How many to add?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(308, 366);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 24;
            label6.Text = "File accesses:";
            // 
            // button2
            // 
            button2.Location = new Point(432, 68);
            button2.Name = "button2";
            button2.Size = new Size(60, 49);
            button2.TabIndex = 23;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(308, 228);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 22;
            label4.Text = "Fill text with";
            // 
            // button1
            // 
            button1.Location = new Point(308, 314);
            button1.Name = "button1";
            button1.Size = new Size(184, 49);
            button1.TabIndex = 21;
            button1.Text = "Auto fill";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(309, 146);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 26;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(316, 190);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(190, 24);
            checkBox1.TabIndex = 27;
            checkBox1.Text = "Delete Previous Content";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(308, 251);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(157, 24);
            radioButton1.TabIndex = 28;
            radioButton1.TabStop = true;
            radioButton1.Text = "Random characters";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(308, 278);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(83, 24);
            radioButton2.TabIndex = 29;
            radioButton2.TabStop = true;
            radioButton2.Text = "Brainrot";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(checkBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(button1);
            Name = "Form6";
            Text = "FormAutoFill";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Button button2;
        private Label label4;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private CheckBox checkBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}