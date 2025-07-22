namespace StudentGPAcalc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            txtGrade1 = new Label();
            txtGrade2 = new Label();
            txtGrade3 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(32, 55);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(32, 97);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(32, 141);
            label3.Name = "label3";
            label3.Size = new Size(127, 28);
            label3.TabIndex = 2;
            label3.Text = "Department";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 10F, FontStyle.Italic);
            textBox1.Location = new Point(173, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 32);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Calibri", 10F, FontStyle.Italic);
            textBox2.Location = new Point(173, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 32);
            textBox2.TabIndex = 4;
            // 
            // txtGrade1
            // 
            txtGrade1.AutoSize = true;
            txtGrade1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGrade1.Location = new Point(32, 349);
            txtGrade1.Name = "txtGrade1";
            txtGrade1.Size = new Size(86, 28);
            txtGrade1.TabIndex = 6;
            txtGrade1.Text = "Grade 1";
            // 
            // txtGrade2
            // 
            txtGrade2.AutoSize = true;
            txtGrade2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtGrade2.Location = new Point(32, 401);
            txtGrade2.Name = "txtGrade2";
            txtGrade2.Size = new Size(86, 28);
            txtGrade2.TabIndex = 7;
            txtGrade2.Text = "Grade 2";
            // 
            // txtGrade3
            // 
            txtGrade3.AutoSize = true;
            txtGrade3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtGrade3.Location = new Point(32, 451);
            txtGrade3.Name = "txtGrade3";
            txtGrade3.Size = new Size(86, 28);
            txtGrade3.TabIndex = 8;
            txtGrade3.Text = "Grade 3";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Calibri", 10F, FontStyle.Italic);
            textBox3.Location = new Point(173, 343);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(191, 32);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Calibri", 10F, FontStyle.Italic);
            textBox4.Location = new Point(173, 395);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(191, 32);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Calibri", 10F, FontStyle.Italic);
            textBox5.Location = new Point(173, 445);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(191, 32);
            textBox5.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Calibri", 10F, FontStyle.Italic);
            button1.Location = new Point(173, 507);
            button1.Name = "button1";
            button1.Size = new Size(191, 34);
            button1.TabIndex = 12;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "CS", "SE", "IT", "BBA", "LAW", "DPT" });
            listBox1.Location = new Point(173, 152);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(300, 154);
            listBox1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(530, 576);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(txtGrade3);
            Controls.Add(txtGrade2);
            Controls.Add(txtGrade1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GPA Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label txtGrade1;
        private Label txtGrade2;
        private Label txtGrade3;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private ListBox listBox1;
    }
}
