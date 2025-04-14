using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            { label1.BackColor = Color.Red; BackColor = Color.Orange; }
            if (e.Button == MouseButtons.Right)
            { label1.BackColor = Color.Green; BackColor = Color.MediumSpringGreen; }
        }

        private void label1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label1.BackColor = Color.Blue; BackColor = Color.Aqua;
        }

        private void Form5_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));

        }
    }
}
