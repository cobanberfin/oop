using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrencifakedata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ogrenci> ogrlist = new List<ogrenci>();
          for( int i = 1; i < 100; i++)
            {
                ogrenci ogr = new ogrenci();
                ogr.id = i;
                ogr.isim = FakeData.NameData.GetFirstName();
                ogr.Soyisim = FakeData.NameData.GetSurname();
                ogr.Telefon = FakeData.PhoneNumberData.GetPhoneNumber();

                ogrlist.Add(ogr);
                

            }
            dataGridView1.DataSource = ogrlist;

        }
    }
}
