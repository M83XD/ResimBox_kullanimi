using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resimGoster(int deger)
        {
            switch (deger)
            {
                case 1:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\user\Downloads\Fantezi\Recep.jpg");
                        pictureBox2.Image = Image.FromFile(@"C:\Users\user\Downloads\Fantezi\Recep.jpg");
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\user\Downloads\Fantezi\gulenadam.jpg");
                    pictureBox2.Image = Image.FromFile(@"C:\Users\user\Downloads\Fantezi\gulenadam.jpg");
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\user\Downloads\Fantezi\Sage.jpg");
                    pictureBox2.Image = Image.FromFile(@"C:\Users\user\Downloads\Fantezi\Sage.jpg");
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\user\Downloads\Fantezi\tabiefendm.jpg");
                    pictureBox2.Image = Image.FromFile(@"C:\Users\user\Downloads\Fantezi\tabiefendm.jpg");
                    break;
                case 5:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\user\Downloads\Fantezi\hiko.jpg");
                    pictureBox2.Image = Image.FromFile(@"C:\Users\user\Downloads\Fantezi\hiko.jpg");
                    break;
                case 6:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\user\Downloads\Fantezi\mıho.jpg");
                    pictureBox2.Image = Image.FromFile(@"C:\Users\user\Downloads\Fantezi\mıho.jpg");
                    break;
                case 7:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\user\Downloads\Fantezi\At.jpg");
                    pictureBox2.Image = Image.FromFile(@"C:\Users\user\Downloads\Fantezi\At.jpg");
                    break;
                case 8:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\user\Downloads\Fantezi\mıho2.jpg");
                    pictureBox2.Image = Image.FromFile(@"C:\Users\user\Downloads\Fantezi\mıho2.jpg");
                    break;
                case 9:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\user\Downloads\Fantezi\savunma.jpg");
                    pictureBox2.Image = Image.FromFile(@"C:\Users\user\Downloads\Fantezi\savunma.jpg");
                    break;
                case 10:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\user\Downloads\Fantezi\kürt1.jpg");
                    pictureBox2.Image = Image.FromFile(@"C:\Users\user\Downloads\Fantezi\kürt1.jpg");
                    break;
            }
        }
        int knt = 10;
        private void button1_Click(object sender, EventArgs e)
        {
            knt++;
            if (knt <= 10)
                resimGoster(knt);
            else
                knt = 10;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            knt--;
            if (knt <= 10)
                resimGoster(knt);
            else
                knt = 10;
        }
        Random rgele = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            resimGoster(rgele.Next(1, 10));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            knt = 1;
            pictureBox1.Image = Image.FromFile(@"C:\Users\user\Downloads\Fantezi\Recep.jpg");
            timer1.Enabled = false;
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            knt = 10;
            pictureBox1.Image = Image.FromFile(@"C:\Users\user\Downloads\Fantezi\kürt1.jpg");
            timer1.Enabled = false;
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            knt = (int)comboBox1.SelectedItem;
            resimGoster(knt);
        }
    } 
}
