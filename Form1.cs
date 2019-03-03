using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21._10._2018_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string v in listBox1.Items)
                if (v.Substring(4, 3) == "212")
                    listBox4.Items.Add(v);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double sonuc = 0;
            char isaret;
            double sayi1, sayı2;
            foreach (string item in listBox2.Items)
            {
                int yer;
                if (item.Contains('+'))
                {
                    isaret = '+';
                    yer = item.IndexOf(isaret);
                    sayi1 = Convert.ToDouble(item.Substring(0, yer));
                    sayı2 = Convert.ToDouble(item.Substring(yer + 1));
                    sonuc = sayi1 + sayı2;
                }
                else if (item.Contains('-'))
                {
                    isaret = '-';
                    yer = item.IndexOf(isaret);
                    sayi1 = Convert.ToDouble(item.Substring(0, yer));
                    sayı2 = Convert.ToDouble(item.Substring(yer + 1));
                    sonuc = sayi1 - sayı2;
                }
                else if (item.Contains('*'))
                {
                    isaret = '*';
                    yer = item.IndexOf(isaret);
                    sayi1 = Convert.ToDouble(item.Substring(0, yer));
                    sayı2 = Convert.ToDouble(item.Substring(yer + 1));
                    sonuc = sayi1 * sayı2;
                }
                else if (item.Contains('/'))
                {
                    isaret = '/';
                    yer = item.IndexOf(isaret);
                    sayi1 = Convert.ToDouble(item.Substring(0, yer));
                    sayı2 = Convert.ToDouble(item.Substring(yer + 1));
                    sonuc = sayi1 / sayı2;
                }
                listBox4.Items.Add(sonuc.ToString());
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            double sonuc = 0;
            char isaret;
            double sayi1, sayı2;
            foreach (string item in listBox3.Items)
            {
                int yer;
                if (item.Contains('+'))
                {
                    isaret = '+';
                    yer = item.IndexOf(isaret);
                    sayi1 = Convert.ToDouble(item.Substring(0, yer));
                    sayı2 = Convert.ToDouble(item.Substring(yer + 1));
                    sonuc = sayi1 + sayı2;
                }
                else if (item.Contains('-'))
                {
                    isaret = '-';
                    yer = item.IndexOf(isaret);
                    sayi1 = Convert.ToDouble(item.Substring(0, yer));
                    sayı2 = Convert.ToDouble(item.Substring(yer + 1));
                    sonuc = sayi1 - sayı2;
                }
                else if (item.Contains('*'))
                {
                    isaret = '*';
                    yer = item.IndexOf(isaret);
                    sayi1 = Convert.ToDouble(item.Substring(0, yer));
                    sayı2 = Convert.ToDouble(item.Substring(yer + 1));
                    sonuc = sayi1 * sayı2;
                }
                else if (item.Contains('/'))
                {
                    isaret = '/';
                    yer = item.IndexOf(isaret);
                    sayi1 = Convert.ToDouble(item.Substring(0, yer));
                    sayı2 = Convert.ToDouble(item.Substring(yer + 1));
                    sonuc = sayi1 / sayı2;
                }
                listBox4.Items.Add(sonuc.ToString());
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            double [] dizi = new double[listBox4.Items.Count];
            int i = 0;
                foreach (string item in listBox4.Items)
                {
                    dizi[i] = Convert.ToDouble(item);
                    i++;
                }  
            Array.Sort(dizi);
            foreach(double sayi in dizi)
                listBox5.Items.Add(sayi);      
        }
    }
}
