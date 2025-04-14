using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            // textBox2.Text = textBox1.Text + " " + comboBox1.Text;
            //listBox1.Items.Clear();
            // listBox1.Items.Add(textBox1.Text +" "+comboBox1.Text); 
            
            
            Student k = new Student(textBox1.Text,comboBox1.Text);
            textBox2.Text = k.INFO();
            listBox1.Items.Add(k.INFO());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
