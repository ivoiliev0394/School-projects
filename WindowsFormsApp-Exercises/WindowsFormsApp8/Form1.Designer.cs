
namespace WindowsFormsApp8
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
            this.lblF = new System.Windows.Forms.Label();
            this.picF = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picF)).BeginInit();
            this.SuspendLayout();
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblF.ForeColor = System.Drawing.Color.White;
            this.lblF.Location = new System.Drawing.Point(12, 9);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(225, 76);
            this.lblF.TabIndex = 0;
            this.lblF.Text = "Франция";
            // 
            // picF
            // 
            this.picF.Image = global::WindowsFormsApp8.Properties.Resources.Ивайло_Илиев___France;
            this.picF.Location = new System.Drawing.Point(277, 135);
            this.picF.Name = "picF";
            this.picF.Size = new System.Drawing.Size(200, 180);
            this.picF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picF.TabIndex = 1;
            this.picF.TabStop = false;
            this.picF.MouseEnter += new System.EventHandler(this.picF_MouseEnter);
            this.picF.MouseLeave += new System.EventHandler(this.picF_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picF);
            this.Controls.Add(this.lblF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.PictureBox picF;
    }
}

