using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCNoEntagrasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long tcNo = Convert.ToInt64(txtboxTC.Text);
            string ad = txtboxAd.Text.ToUpper();
            string soyad = txtBoxSoyad.Text.ToUpper();
            int dYil = Convert.ToInt32(txtBoxDYil.Text);
            KimlikReferans.KPSPublicSoapClient servis = new KimlikReferans.KPSPublicSoapClient();
            bool teyit = servis.TCKimlikNoDogrula(tcNo, ad, soyad, dYil);
            if (teyit)
            {
                MessageBox.Show("Kimlik Doğru");
            }
            else
            {
                MessageBox.Show("Kimlik Yanlış");
            }
        }

        
    }
}
