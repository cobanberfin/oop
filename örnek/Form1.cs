using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Musteri> mlist = new List<Musteri>();
        private void button1_Click(object sender, EventArgs e)
        {

            Musteri m = new Musteri();
            m.Id = Convert.ToInt32(textBoxıd.Text);
            m.Ad = textBoxad.Text;
            m.Soyad = textBoxsoyad.Text;
            m.KrediKart = textBoxkredik.Text;
            mlist.Add(m);
            Temizle();
          
        }
        private  void Temizle()
        {
            textBoxıd.Clear();
            textBoxad.Clear();
            textBoxsoyad.Clear();
            textBoxkredik.Clear();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Musteri> m = new List<Musteri>();
            foreach (var item in mlist)
            {
                Musteri mst = new Musteri();

                mst.Id = item.Id;
                mst.Ad = item.Ad;
                mst.Soyad = item.Soyad;

                mst.KrediKart = item.KrediKart;

                m.Add(mst);


            }
            dataGridView1.DataSource = m;

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            Musteri secilen = (Musteri)dataGridView1.CurrentRow.DataBoundItem;
            textADD.Text = secilen.Ad;
            textBoxSOYD.Text = secilen.Soyad;
            textBoxKK.Text = secilen.KrediKart;





        }
    }
}
