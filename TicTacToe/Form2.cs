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
    public partial class Form2 : Form
    {
        Button[,] b;
        int n,nr; 
        public Form2()
        {
            InitializeComponent();
            button3.Enabled = false;
            int i, j;
            n = dimensiune.nr;
            nr = 1;
            b = new Button[n + 1, n + 1];//creare matrice de diensiune data
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                {
                    b[i, j] = new Button();//creare fiecare buton
                    b[i, j].Size = new Size(100, 100);//stabilire dimensiuni buton
                    b[i, j].BackColor = Color.Black;//stabilire culoare fundal pt fiecare buton
                    b[i, j].Location = new Point(155+(650-n*50) + 100 * j, 13+(480-n*50) + 100 * i);//stabilesc pozitia fiecarui buton din matrice
                    this.Controls.Add(b[i, j]);//aduc butonul pe form
                    b[i, j].Enabled = true;
                    b[i, j].Click += new System.EventHandler(buton_clic);
                }
            textBox1.Text = "X";
        }
        private void buton_clic(object sender, EventArgs e)
        {
            int i, j;
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    if (b[i, j] == sender)
                        joaca(b[i,j]);
            nr++;
            if(nr%2==0)
                textBox1.Text = "0";
            else
                textBox1.Text = "X";
        }
        private void joaca(Button x)
        {
            int i, j;
            if (nr % 2 == 0)
            {
                x.BackgroundImage = Properties.Resources._0_ttt;
                x.BackColor = Color.Aqua;
                if (gata_joco() == true)
                {
                    for (i = 0; i < n; i++)
                        for (j = 0; j < n; j++)
                            b[i, j].Enabled = false;
                    Form3 f = new Form3();
                    f.Show();
                }
            }
            else
            { x.BackgroundImage = Properties.Resources.x_ttt;
                x.BackColor = Color.Beige;
            if (gata_jocx() == true)
            {
                for (i = 0; i < n; i++)
                    for (j = 0; j < n; j++)
                        b[i, j].Enabled = false;
                Form5 f = new Form5();
                f.Show();
            } }
            x.Enabled = false;
            if(Tablă()==true)
            {
                if((gata_joco()== false)&& (gata_jocx() == false))
                {
                    Form4 f = new Form4();
                    f.Show();
                }
            }
        }
        private bool gata_jocx()
        {
            bool okd=false, okl=false, okc=false;
            int i, j;
            for (i = 0; i < n; i++)
            {
                okc = true;
                for (j = 0; j < n; j++)
                    if (b[i, j].BackColor != Color.Beige)
                        okc= false;

                if (okc == true)
                    return true;
            }
            for (i = 0; i < n; i++)
            {
                okl = true;
                for (j = 0; j < n; j++)
                    if (b[j, i].BackColor != Color.Beige)
                        okl = false;
                if (okl == true)
                    return true;
            }
            okd = true;
            for (i = 0; i < n; i++)
                if (b[i, i].BackColor != Color.Beige)
                    okd = false;
            if (okd == true)
                return true;
            okd = true;
            for (i = 0; i < n; i++)
                if (b[i, n-1-i].BackColor != Color.Beige)
                    okd = false;
            if (okd == true)
                return true;
            return false;
        }
        private bool gata_joco()
        {
            bool okd = false, okl = false, okc = false;
            int i, j;
            for (i = 0; i < n; i++)
            {
                okc = true;
                for (j = 0; j < n; j++)
                    if (b[i, j].BackColor != Color.Aqua)
                        okc = false;

                if (okc == true)
                    return true;
            }
            for (i = 0; i < n; i++)
            {
                okl = true;
                for (j = 0; j < n; j++)
                    if (b[j, i].BackColor != Color.Aqua)
                        okl = false;
                if (okl == true)
                    return true;
            }
            okd = true;
            for (i = 0; i < n; i++)
                if (b[i, i].BackColor != Color.Aqua)
                    okd = false;
            if (okd == true)
                return true;
            okd = true;
            for (i = 0; i < n; i++)
                if (b[i, n-1-i].BackColor != Color.Aqua)
                    okd = false;
            if (okd == true)
                return true;
            return false;
        }
        private bool Tablă()
        {
            int i, j;
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    if (b[i, j].Enabled == true)
                        return false;
               return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j;
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                {
                    b[i, j].BackColor = Color.Black;
                    b[i, j].Enabled = true;
                    b[i,j].BackgroundImage = Properties.Resources.fundal;
                }
            nr = 1;
            textBox1.Text = "X";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
