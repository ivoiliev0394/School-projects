using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComboBox[] marks = { comboBox1, comboBox2, comboBox3, comboBox4, comboBox5, comboBox6, comboBox7,
                comboBox8, comboBox9, comboBox10, comboBox11, comboBox12, comboBox13, comboBox14, comboBox15 };
            textBox1.Text = "";
            for(int i=0;i<marks.Length;i++)
            {
                if(marks[i].SelectedIndex==-1)
                {
                    MessageBox.Show("Има непопълнени оценки!", "Информация");
                    return;
                }
            }
            int sum = 0, num = 14;
            for(int i=0;i<14;i++)
            {
                sum = sum + int.Parse(marks[i].Text);
            }
            if(marks[14].Text!="освободен")
            {
                sum = sum + int.Parse(marks[14].Text);
                num = 15;
            }
            double average = (double)sum / num;
            //textBox1.Text = Math.Round(average, 2).ToString();
            textBox1.Text = string.Format("{0:F2}", average);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
