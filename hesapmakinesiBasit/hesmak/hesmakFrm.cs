using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesmak
{
    public partial class hesmakFrm : Form
    {
        Double sayi1, sayi2, sonuc;
        String islem = "";
        public hesmakFrm()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            ekrantxt.Text = ekrantxt.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ekrantxt.Text = ekrantxt.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ekrantxt.Text = ekrantxt.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ekrantxt.Text = ekrantxt.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ekrantxt.Text = ekrantxt.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ekrantxt.Text = ekrantxt.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ekrantxt.Text = ekrantxt.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ekrantxt.Text = ekrantxt.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ekrantxt.Text = ekrantxt.Text + "8";
        }

        private void btnesit_Click(object sender, EventArgs e)
        {
            if (ekrantxt.Text != "")
            {
                sayi2 = Convert.ToDouble(ekrantxt.Text);
                if (islem == "+")
                {
                    sonuc = sayi1 + sayi2;
                }
                else if (islem == "-")
                {
                    sonuc = sayi1 - sayi2;
                }
                else if (islem == "*")
                {
                    sonuc = sayi1 * sayi2;
                }
                else if (islem == "/")
                {
                    sonuc = sayi1 / sayi2;
                }
                if(sonuc.ToString().Length>16)
                {
                    MessageBox.Show("Sayı Ekrana Sığmıyor");
                }
                else
                {
                    ekrantxt.Text = sonuc.ToString();
                }
                
            }
        }

        private void btncikar_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(ekrantxt.Text);
            ekrantxt.Text = "";
            islem = "-";
        }

        private void btncarp_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(ekrantxt.Text);
            ekrantxt.Text = "";
            islem = "*";
        }

        private void btnbol_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(ekrantxt.Text);
            ekrantxt.Text = "";
            islem = "/";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            ekrantxt.Text = "";
            sayi1 = 0;
            sayi2 = 0;
            sonuc = 0;
            islem= "";
        }

        private void btnvirgul_Click(object sender, EventArgs e)
        {
            if (ekrantxt.Text.Length > 0&&ekrantxt.Text.Contains(",")==false)
            {
                ekrantxt.Text = ekrantxt.Text + ",";
            }
        }

        private void btnisaret_Click(object sender, EventArgs e)
        {
            if (ekrantxt.Text.Length > 0)
            {
                Double sayi = Convert.ToDouble(ekrantxt.Text);
                sayi = sayi * -1;
                ekrantxt.Text = sayi.ToString();
            }
        }

        private void btnkarekok_Click(object sender, EventArgs e)
        {
            if (ekrantxt.Text.Length > 0)
            {
                Double sayi = Convert.ToDouble(ekrantxt.Text);
                Double karekok=Math.Sqrt(sayi);
                ekrantxt.Text = karekok.ToString();
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ekrantxt.Text = ekrantxt.Text + "9";
        }

        private void btntopla_Click(object sender, EventArgs e)
        {
            sayi1=Convert.ToDouble(ekrantxt.Text);
            ekrantxt.Text = "";
            islem = "+";
        }
    }
}
