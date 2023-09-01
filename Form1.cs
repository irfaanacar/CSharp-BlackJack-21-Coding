using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack21Yapimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele=new Random();
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 1) { 
            int a1, a2, toplam;
            a1 = rastgele.Next(1,11);
            a2 = rastgele.Next(1, 11);
            toplam = a1 + a2;
            label1.Text = a1.ToString();
            label2.Text = a2.ToString();
            label6.Text= toplam.ToString();
            }
            if (sayac == 2)
            {
                int a3,toplam;
                a3 = rastgele.Next(1, 11);
                label3.Text=a3.ToString();
                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + a3;
                label6.Text = toplam.ToString();
            }
            if(sayac == 3)
            {
                int a4,toplam;
                a4 = rastgele.Next(11, 11);
                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) +Convert.ToInt32(label3.Text) + a4;
                label6.Text = toplam.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b1, b2, toplam;
            b1 = rastgele.Next(1, 11);
            b2 = rastgele.Next(1, 11);
            toplam = b1 + b2;
            label7.Text=b1.ToString();
            label8.Text=b2.ToString();
            label12.Text=toplam.ToString();


            if (toplam < 16)
            {
                int b3;
                b3 = rastgele.Next(1, 11);
                label9.Text=b3.ToString();
                toplam = toplam + b3;
                label12.Text = toplam.ToString();    
            }
            if(toplam < 16)
            {
                int b4;
                b4 = rastgele.Next(1, 11);
                label10.Text=b4.ToString();

                toplam=toplam + b4;
                label12.Text = toplam.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int oyuncutoplam, pctoplam,oyuncupuan=0,pcpuan=0;
            oyuncutoplam = Convert.ToInt32(label6.Text);
            pctoplam= Convert.ToInt32(label12.Text);
            if(oyuncutoplam>pctoplam && oyuncutoplam <= 21)
            {
                oyuncupuan = oyuncupuan + 10;
                label20.Text=oyuncupuan.ToString();
            }
            if(pctoplam>oyuncutoplam && pctoplam <= 21)
            {
                pcpuan=pcpuan+10;
                label19.Text=pcpuan.ToString();
            }
            if(pctoplam>21 && oyuncutoplam > 21)
            {
                MessageBox.Show("değerler büyük berabere kalındı");
            }
            if(pctoplam==oyuncutoplam && pctoplam<=21 && oyuncutoplam <= 21)
            {
                pcpuan = pcpuan + 10;
                oyuncupuan=oyuncupuan + 10;
                label20.Text = oyuncupuan.ToString();
                label19.Text = pcpuan.ToString();

            }
            if(pctoplam<=21 && oyuncutoplam > 21)
            {
                pcpuan = pcpuan + 10;
                label19.Text = pcpuan.ToString();
            }
            if(oyuncutoplam<=21 && pctoplam > 21){
                oyuncupuan = oyuncupuan + 10;
                label20.Text = oyuncupuan.ToString();

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayac = 0;
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "0";
            label9.Text = "0";
            label10.Text = "0";
            label12.Text = "0";
        }
    }
        
    }
