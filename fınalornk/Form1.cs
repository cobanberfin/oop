using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fınalornk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Ogrenci> ogrlist = new List<Ogrenci>();//girilenlenleri tek tek listeye al

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Ad = textBoxAd.Text;
            ogr.Soyad = textBoxSoyad.Text;
            ogr.Bölüm = textBoxBolum.Text;
            ogr.Sınıf = textBoxSınıf.Text;

            ogrlist.Add(ogr);
            Temizle();

        }
        private void Temizle()
        {
            textBoxAd.Clear();
            textBoxSoyad.Clear();
            textBoxSınıf.Clear();
            textBoxBolum.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Ogrenci> olist = new List<Ogrenci>();

            foreach (var item in ogrlist)
            {
            Ogrenci ogr = new Ogrenci();
                ogr.Ad = item.Ad;
                ogr.Bölüm = item.Bölüm;
                ogr.Soyad = item.Soyad;
                ogr.Sınıf = item.Sınıf;

                olist.Add(ogr);

            }
            dataGridView1.DataSource = olist;

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Ogrenci secılen = (Ogrenci)dataGridView1.CurrentRow.DataBoundItem;
            textBoxAd2.Text = secılen.Ad;
           // textBoxsoyad2.Text = secılen.Soyad2;

        }
    }
}
