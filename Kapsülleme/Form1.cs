using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kapsülleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            ogrenci o = new ogrenci();
            o.Ad = textBoxad.Text = Text;
            o.Soyad = textBoxsoyad.Text = Text;
            o.Tc = Convert.ToInt64(textBoxTc.Text);

             ListViewItem kayit = new ListViewItem();
            kayit.Text = o.Tc.ToString();
            kayit.SubItems.Add(o.Ad);
            kayit.SubItems.Add(o.Soyad);
            listView1.Items.Add(kayit);

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
