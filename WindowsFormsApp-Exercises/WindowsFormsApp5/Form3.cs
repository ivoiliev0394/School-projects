using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string[] s = { "късмет", "здраве", "щастие", "познание","учение","пиене","доходи","пари","имот"};
        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int i = r.Next(1, 9);
            pictureBox2.Image = imageList1.Images[i];
            label1.Text = "Вашия  късмет е: " + s[i];
           
        }
    }
}
