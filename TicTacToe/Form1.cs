using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat_Bianca_Grava_Tania_Ionita
{
    public partial class Form1 : Form
    {
        int n;
        public Form1()
        {
            InitializeComponent();
            button4.Enabled = false;
            button2.Enabled = false;
            button5.Enabled = false;
        }
         
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(textBox1.Text);
            dimensiune.nr = n;
            if(n>9||n<3)
            {
                Form6 f = new Form6();
                f.Show();
            }
            else
            { 
            Form2 f = new Form2();
            f.Show();}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
