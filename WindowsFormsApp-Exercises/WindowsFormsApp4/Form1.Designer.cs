
namespace WindowsFormsApp4
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btngenerating = new System.Windows.Forms.Button();
            this.txtgenerating = new System.Windows.Forms.TextBox();
            this.btnnext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(192, 178);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Изход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btngenerating
            // 
            this.btngenerating.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btngenerating.Location = new System.Drawing.Point(85, 178);
            this.btngenerating.Name = "btngenerating";
            this.btngenerating.Size = new System.Drawing.Size(75, 23);
            this.btngenerating.TabIndex = 1;
            this.btngenerating.Text = "Генериране";
            this.btngenerating.UseVisualStyleBackColor = true;
            this.btngenerating.Click += new System.EventHandler(this.btngenerating_Click);
            // 
            // txtgenerating
            // 
            this.txtgenerating.Location = new System.Drawing.Point(145, 102);
            this.txtgenerating.Name = "txtgenerating";
            this.txtgenerating.Size = new System.Drawing.Size(182, 20);
            this.txtgenerating.TabIndex = 2;
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(307, 178);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(75, 23);
            this.btnnext.TabIndex = 3;
            this.btnnext.Text = "-->";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btngenerating;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(487, 282);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.txtgenerating);
            this.Controls.Add(this.btngenerating);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btngenerating;
        private System.Windows.Forms.TextBox txtgenerating;
        private System.Windows.Forms.Button btnnext;
    }
}

