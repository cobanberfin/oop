using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataUret
{
    public class DUret
    {
        string[] adlar = { "gül", "ela", "selin", "ali", "eda" };
        string[] Soyadlar = { "güllü", "elamur", "say", "aliye" };

        string[] sehirler = { "van", "ankara", "izmir", "bolu", "mars" };
        static Random rnd = new Random();


        public string GetName()
        {
            int sayi = rnd.Next(0, adlar.Length);
            return adlar[sayi];
        }
        public string GetSurName()
        {
            int sayi = rnd.Next(0, Soyadlar.Length);
            return Soyadlar[sayi];
        }
        public string City()
        {
            int sayi = rnd.Next(0, sehirler.Length);
            return sehirler[sayi];
        }
        public DateTime GetBackDate(int year)
        {
            year = -1 * rnd.Next(0, year);
            return DateTime.Now.AddYears(year);
        }
        public DateTime ForwadDate(int year)
        {
            year = rnd.Next(0, year);
            return DateTime.Now.AddYears(year);
        }
    }
}
