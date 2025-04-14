
namespace WindowsFormsApp4
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
            this.btnG = new System.Windows.Forms.Button();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.btnM = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnG
            // 
            this.btnG.Location = new System.Drawing.Point(181, 220);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(80, 30);
            this.btnG.TabIndex = 0;
            this.btnG.Text = "Генериране";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Location = new System.Drawing.Point(12, 12);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(148, 277);
            this.lst1.TabIndex = 1;
            // 
            // btnM
            // 
            this.btnM.Location = new System.Drawing.Point(181, 256);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(80, 30);
            this.btnM.TabIndex = 2;
            this.btnM.Text = "Минимум";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(269, 220);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(100, 66);
            this.btnR.TabIndex = 3;
            this.btnR.Text = "Замяна на min със случайно число";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(479, 256);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(266, 115);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(0, 13);
            this.lblR.TabIndex = 5;
            // 
            // Form4
            // 
            this.AcceptButton = this.btnG;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(581, 308);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.lst1);
            this.Controls.Add(this.btnG);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblR;
    }
}