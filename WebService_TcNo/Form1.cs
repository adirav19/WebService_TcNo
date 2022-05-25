using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebService_TcNo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            long kimlikno = long.Parse(txttc.Text);
            int yil = int.Parse(txtyil.Text);
            bool durum;
            try
            {
                using (TcDogrula.KPSPublicSoapClient service = new TcDogrula.KPSPublicSoapClient { })
                {
                    durum = service.TCKimlikNoDogrula(kimlikno, txtad.Text, txtsoyad.Text, yil);
                }
            }
            catch (Exception)
            {

                throw;
            }
            MessageBox.Show(durum.ToString());
        }
    }
}
