using DataUret;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//liste oluşcak ögrencı alanları barındıran ve metotlarla verılerı doldurcam
            List<ogrenci> olist = new List<ogrenci>();
            for(int i = 1; i < 100; i++)
            {
                ogrenci ogr = new ogrenci();
                DUret d = new DUret();

                ogr.id = i;
                ogr.ad = d.GetName();
                ogr.DogumYer = d.City();
                ogr.DogumTarihi = d.GetBackDate(28);
                ogr.KursBitisTarihi = d.ForwadDate(3);
                olist.Add(ogr);


            }
            dataGridView1.DataSource = olist;

        }
    }
}
