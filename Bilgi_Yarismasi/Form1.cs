using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            Btnsonraki.Enabled = true;

            label5.Text = BtnB.Text;
            if (label5.Text == lbldogrucevap.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();

            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            Btnsonraki.Enabled = true;

            label5.Text = BtnC.Text;
            if (lbldogrucevap.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();

            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            Btnsonraki.Enabled = true;

            label5.Text = BtnD.Text;
            if (lbldogrucevap.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();

            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            Btnsonraki.Enabled = true;

            label5.Text = BtnA.Text;
            if (label5.Text == lbldogrucevap.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();

            }
            else
            {
                yanlis++;
                lblyanlis.Text= yanlis.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            Btnsonraki.Enabled = false;


            soruno++;
            lblsoruno.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "En sevdiğim kişi";
                BtnA.Text = "Hera";
                BtnB.Text = "Zehra";
                BtnC.Text = "Hera";
                BtnD.Text = "Hera";

                lbldogrucevap.Text = "Zehra";
                
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Hangisini çok severim";
                BtnA.Text = "Yemek yemek";
                BtnB.Text = "Yatmak";
                BtnC.Text = "Oyun oynamak";
                BtnD.Text = "Hepsi";
                lbldogrucevap.Text = "Hepsi";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Benim kız ne zaman doğdu";
                BtnA.Text = "18 Kasım 2000";
                BtnB.Text = "19 Kasım 2000";
                BtnC.Text = "17 Kasım 2000";
                BtnD.Text = "16 Kasım 2000";
                lbldogrucevap.Text = "18 Kasım 2000"; 

            }
            if (soruno == 4)
            {
                richTextBox1.Text = "";
                BtnA.Text = "";
                BtnB.Text = "";
                BtnC.Text = "";
                BtnD.Text = "";

                BtnA.Enabled= false;
                BtnB.Enabled= false;
                BtnC.Enabled= false;
                BtnD.Enabled= false;
                Btnsonraki.Enabled= false;
                MessageBox.Show(" Doğru: " + dogru + "\n" + " Yanlış: " + yanlis);
            }
        }
    }
}
