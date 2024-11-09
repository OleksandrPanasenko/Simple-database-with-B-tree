namespace Database_B_tree
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label6 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 310);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 34;
            label6.Text = "File accesses:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(74, 126);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(184, 104);
            textBox3.TabIndex = 32;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(75, 72);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(184, 27);
            textBox2.TabIndex = 31;
            // 
            // button2
            // 
            button2.Location = new Point(199, 17);
            button2.Name = "button2";
            button2.Size = new Size(60, 49);
            button2.TabIndex = 30;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 290);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 29;
            label4.Text = "File accesses:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 46);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 28;
            label3.Text = "Index:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 102);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 27;
            label2.Text = "Text";
            // 
            // button1
            // 
            button1.Location = new Point(75, 236);
            button1.Name = "button1";
            button1.Size = new Size(184, 49);
            button1.TabIndex = 25;
            button1.Text = "Add record";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(129, 45);
            button3.Name = "button3";
            button3.Size = new Size(60, 25);
            button3.TabIndex = 35;
            button3.Text = "Auto";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(129, 100);
            button4.Name = "button4";
            button4.Size = new Size(60, 25);
            button4.TabIndex = 36;
            button4.Text = "Auto";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            Text = "FormAddRecord";
            FormClosed += Form4_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}