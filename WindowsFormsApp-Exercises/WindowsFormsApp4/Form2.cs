using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            string[] s = txt1.Lines;
            int a = Array.IndexOf(s, txt3.Text);
            if (a != -1) lblResult.Text = "На " + a.ToString() + " позиция.";
            else lblResult.Text = "Няма такъв град!";
            
          /*  string[] s = txt1.Lines;
            bool b = false;
            for(int i=0;i<s.Length;i++)
                if(s[i]==txt3.Text) { b = true; lblResult.Text = "На " + i.ToString() + " позиция."; }
            if (b == false) lblResult.Text = "Няма такъв град!";
          */

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string[] s = txt1.Lines;
            Array.Sort(s);
            txt2.Lines = s;
            // string[] s = txt1.Lines; foreach (string a in s) txt2.AppendText(a + "\r\n");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }
    }
}
