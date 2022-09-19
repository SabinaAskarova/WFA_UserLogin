using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WFA_UserLogin
{
    public partial class Form1 : MetroForm
    {
            StringBuilder str = new StringBuilder();

        public Form1()
        {
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                str.Append(random.Next(0, 9).ToString());
            }
            
            //MessageBox.Show(str.ToString());
            InitializeComponent();

        }

        int count = 5;

        private void btnLogin_Click(object sender, EventArgs e)
        {

            CheckLogin(count);
            count--;

        }

        public void CheckLogin(int count)
        {
            if (txtGirisAlani.Text == str.ToString())
            {
                MessageBox.Show("Hosgeldiniz!");
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    if (txtGirisAlani.Text == str.ToString())
                    {
                        MessageBox.Show("Hosgeldiniz!");
                        break;
                    }
                    else
                    {

                        //string star = "star" + count;
                        if (count == 5)
                        {
                            star5.Visible = false;

                        }
                        else if (count == 4)
                        {
                            star4.Visible = false;

                        }
                        else if (count == 3)
                        {
                            star3.Visible = false;

                        }
                        else if (count == 2)
                        {
                            star2.Visible = false;

                        }
                        else if (count == 1)
                        {
                            star1.Visible = false;
                            txtGirisAlani.Visible = false;
                            btnLogin.Visible = false;
                            MessageBox.Show("Giriş Sağlanamadı");
                            break ;
                        }
                        
                        txtGirisAlani.Text = "";

                    }
                }


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblRastgeleSayi.Text = str.ToString();
        }

        private void lblRastgeleSayi_Click(object sender, EventArgs e)
        {

        }


        // Randon Nesnesi kullanarak rastgele sayı üretilecek!
    }
}
