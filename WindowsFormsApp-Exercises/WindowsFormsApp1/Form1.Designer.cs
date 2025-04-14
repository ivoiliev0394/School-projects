namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.cbo1 = new System.Windows.Forms.ComboBox();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.btn6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(25, 381);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(106, 40);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Добавяне на име без повторение";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(152, 381);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(94, 40);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Изтриване на ученика";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(301, 381);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(99, 40);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "Съобщение";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(442, 381);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(94, 40);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "избор";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(554, 381);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(85, 40);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "Изход";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "-";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(72, 291);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(193, 20);
            this.txt1.TabIndex = 6;
            // 
            // cbo1
            // 
            this.cbo1.FormattingEnabled = true;
            this.cbo1.Items.AddRange(new object[] {
            "Футбол",
            "Волейбол",
            "Тенис",
            "Баскетбол",
            "Езда"});
            this.cbo1.Location = new System.Drawing.Point(393, 89);
            this.cbo1.Name = "cbo1";
            this.cbo1.Size = new System.Drawing.Size(142, 21);
            this.cbo1.TabIndex = 7;
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Items.AddRange(new object[] {
            "Иван Иванов ",
            "Петър Димитров",
            "Виктор Стоянов"});
            this.lst1.Location = new System.Drawing.Point(68, 57);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(190, 173);
            this.lst1.TabIndex = 8;
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(663, 372);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(102, 59);
            this.btn6.TabIndex = 9;
            this.btn6.Text = "2";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.lst1);
            this.Controls.Add(this.cbo1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Списъци";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.ComboBox cbo1;
        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.Button btn6;
    }
}

