using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        Random r = new Random();
       int n1, n2, n3, n4, n5, n6;
        public Form3()
        {
            InitializeComponent();
        }
       int GRN()
       { return r.Next(1,50);}
        private void btn1_Click(object sender, EventArgs e)
        {
            
            n1 = GRN(); 
            lbl2.Text = n1.ToString();
            do { n2 = GRN(); } while (n2 == n1);  
            lbl4.Text = n2.ToString();
            do { n3 = GRN(); } while (n3 == n1||n3==n2) ;
            lbl6.Text = n3.ToString();
            do { n4 = GRN(); } while (n4 == n1 || n4 == n2||n4==n3);
            lbl8.Text = n4.ToString();
            do { n5 = GRN(); } while (n5 == n1 || n5 == n2 || n5 == n3||n5==n4);
            lbl10.Text = n5.ToString();
            do { n6 = GRN(); } while (n6 == n1 || n6 == n2 || n6 == n3 || n6 == n4||n6==n5);
            lbl12.Text = n6.ToString();
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
           Random r = new Random();
          BackColor=Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            //ForeColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            //this.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            //this.ForeColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
        }
    }
}
