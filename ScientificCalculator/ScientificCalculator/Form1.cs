using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificCalculator
{
    public partial class Form1 : Form
    {
        double islem1, islem2, sonuc;
        string opr;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtEkran.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtEkran.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtEkran.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtEkran.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtEkran.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtEkran.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtEkran.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtEkran.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtEkran.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtEkran.Text += "9";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtEkran.Text = String.Empty;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            txtEkran.Enabled = false;
            txtEkran.Text = "";
            btn0.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }

        private void btnVirgul_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text.Contains(","))
            {
                txtEkran.Text = txtEkran.Text;
            }
            else if (txtEkran.Text=="")
            {
                txtEkran.Text = txtEkran.Text + "0,";
            }
            else
            {
                txtEkran.Text = txtEkran.Text + ",";
            }
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            islem1 = Convert.ToDouble(txtEkran.Text);
            opr = "/";
            txtEkran.Clear();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            islem1 = Convert.ToDouble(txtEkran.Text);
            opr = "*";
            txtEkran.Clear();
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            islem1 = Convert.ToDouble(txtEkran.Text);
            opr = "-";
            txtEkran.Clear();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            islem1 = Convert.ToDouble(txtEkran.Text);
            opr = "+";
            txtEkran.Clear();
        }

        private void btnKare_Click(object sender, EventArgs e)
        {
            sonuc = Convert.ToDouble(txtEkran.Text) * Convert.ToDouble(txtEkran.Text);
            txtEkran.Text = Convert.ToString(sonuc);
        }

        private void btnKup_Click(object sender, EventArgs e)
        {
            sonuc = Convert.ToDouble(txtEkran.Text) * Convert.ToDouble(txtEkran.Text) * Convert.ToDouble(txtEkran.Text);
            txtEkran.Text = Convert.ToString(sonuc);
        }

        private void btnUssu_Click(object sender, EventArgs e)
        {
            islem1 = Convert.ToDouble(txtEkran.Text);
            opr = "x^y";
            txtEkran.Clear();
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtEkran.Text = "3.141592";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sil = txtEkran.Text;
            int n = sil.Length;
            txtEkran.Text = (sil.Substring(0, n - 1));
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            sonuc = System.Math.Log(Convert.ToDouble(txtEkran.Text));
            txtEkran.Text = Convert.ToString(sonuc);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            sonuc = System.Math.Log10(Convert.ToDouble(txtEkran.Text));
            txtEkran.Text = Convert.ToString(sonuc);
        }

        private void btnBirBolu_Click(object sender, EventArgs e)
        {
            sonuc = Convert.ToDouble(1.0 / Convert.ToDouble(txtEkran.Text));
            txtEkran.Text = Convert.ToString(sonuc);
        }

        private void btnFaktor_Click(object sender, EventArgs e)
        {
            int fakt = 1;
            for (int i = 1; i <=Convert.ToInt32(txtEkran.Text) ; i++)
            {
                fakt = i * fakt;
            }
            txtEkran.Text = Convert.ToString(fakt);
        }

        private void btnKareKok_Click(object sender, EventArgs e)
        {
            sonuc = System.Math.Sqrt(Convert.ToDouble(txtEkran.Text));
            txtEkran.Text = Convert.ToString(sonuc);
        }

        private void btnTersi_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text.Contains("-"))
            {
                txtEkran.Text = txtEkran.Text.Remove(0, 1);
            }
            else
            {
                txtEkran.Text = "-" + txtEkran.Text;
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            islem1 = Convert.ToDouble(txtEkran.Text);
            opr = "%";
            txtEkran.Clear();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            txtEkran.Text = Convert.ToString(System.Math.Sin((Convert.ToDouble(System.Math.PI) / 180) * Convert.ToDouble(txtEkran.Text)));
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            txtEkran.Text = Convert.ToString(System.Math.Cos((Convert.ToDouble(System.Math.PI) / 180) * Convert.ToDouble(txtEkran.Text)));
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            txtEkran.Text = Convert.ToString(System.Math.Tan((Convert.ToDouble(System.Math.PI) / 180) * Convert.ToDouble(txtEkran.Text)));
        }

        private void btnCot_Click(object sender, EventArgs e)
        {
            txtEkran.Text = Convert.ToString( 1 / (System.Math.Tan((Convert.ToDouble(System.Math.PI) / 180) * Convert.ToDouble(txtEkran.Text))));
        }

        private void btnEsit_Click(object sender, EventArgs e)
        {
            islem2 = Convert.ToDouble(txtEkran.Text);
            switch(opr)
            {
                case "+":
                    sonuc = islem1 + islem2;
                    txtEkran.Text = Convert.ToString(sonuc);
                    break;

                case "-":
                    sonuc = islem1 - islem2;
                    txtEkran.Text = Convert.ToString(sonuc);
                    break;

                case "*":
                    sonuc = islem1 * islem2;
                    txtEkran.Text = Convert.ToString(sonuc);
                    break;

                case "/":
                    if (islem2==0)
                    {
                        txtEkran.Text = "0";
                        break;
                    }
                    else
                    {
                        sonuc = islem1 / islem2;
                        txtEkran.Text = Convert.ToString(sonuc);
                        break;
                    }

                case "%":
                    sonuc = islem1 % islem2;
                    txtEkran.Text = Convert.ToString(sonuc);
                    break;

                case "x^y":
                    sonuc = System.Math.Pow(Convert.ToDouble(islem1), Convert.ToDouble(islem2));
                    txtEkran.Text = Convert.ToString(sonuc);
                    break;

            }
        }      
    }
}
