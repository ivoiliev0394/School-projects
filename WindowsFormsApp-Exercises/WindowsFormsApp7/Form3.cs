using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.S) pictureBox1.Left += 5;
            else if (e.KeyData == Keys.A) pictureBox1.Left -= 5;
            else if (e.KeyData == Keys.W) pictureBox1.Top -= 5;
            else if (e.KeyData == Keys.Z) pictureBox1.Top += 5;
            else if (e.KeyCode == Keys.Escape) Application.Exit();
            if(pictureBox1.Location==pictureBox2.Location)
            { pictureBox1.Visible = false;pictureBox2.Visible = false;pictureBox3.Visible = true; }
            if (e.KeyCode == Keys.Escape)
                Application.Exit();


             
        }

        
    }
}
