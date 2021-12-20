using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public class ogrenci
    {
        public int id { get; set; }
        public string ad
        {
            get; //database veya farklı verı kaynagı... clası cagıran prgramcıya gösterdıgmıx kısım verıyı oku
            set;//dıs dunyadaan alınan datanın içerıde private olarak saklanan field içerısıne atandgı kısım
        }
        public string soyad { get; set; }
        public string DogumYer { get; set; }
        public DateTime DogumTarihi{ get; set; }

        public DateTime KursBitisTarihi { get; set; }

    }
}
