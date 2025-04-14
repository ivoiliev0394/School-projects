using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void picF_MouseEnter(object sender, EventArgs e)
        {
            lblF.Visible = false;
        }

        private void picF_MouseLeave(object sender, EventArgs e)
        {
            Random r = new Random();
            lblF.Visible = true;
            lblF.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
        }

        private void picF_MouseMove(object sender, MouseEventArgs e)
        {
            
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
              if (e.Button == MouseButtons.Left)
                picF.Location = e.Location;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.D) picF.Left += 5;
            else if (e.KeyData == Keys.A) picF.Left -= 5;
            if (e.KeyCode == Keys.X) { Form2 f = new Form2(); f.Show(); }
               
        }
    }
}
