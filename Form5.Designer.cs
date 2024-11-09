namespace Database_B_tree
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label7 = new Label();
            label6 = new Label();
            button2 = new Button();
            label4 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(137, 61);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 19;
            label7.Text = "Index here";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(138, 214);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 18;
            label6.Text = "File accesses:";
            // 
            // button2
            // 
            button2.Location = new Point(261, 32);
            button2.Name = "button2";
            button2.Size = new Size(60, 49);
            button2.TabIndex = 16;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(137, 194);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 15;
            label4.Text = "File accesses:";
            // 
            // button1
            // 
            button1.Location = new Point(137, 120);
            button1.Name = "button1";
            button1.Size = new Size(184, 49);
            button1.TabIndex = 13;
            button1.Text = "Delete record";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 27);
            textBox1.TabIndex = 12;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form5";
            Text = "FormDeleteRecord";
            FormClosing += Form5_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Button button2;
        private Label label4;
        private Button button1;
        private TextBox textBox1;
    }
}