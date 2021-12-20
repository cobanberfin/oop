using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek
{
   public class Musteri
    {

        public int Id { get; set; }
        public string Ad { get; set; }

        public string  Soyad { get; set; }

        private string _kredikart;
        public string KrediKart {

          
            get {; return getkredikart(); } 
            


            set { _kredikart = value; }


        }
        public string getkredikart()
        {
            string gecici = "";
            int sayi = _kredikart.Substring(0, _kredikart.Length - 2).Length;
            for (int i = 0; i < sayi; i++)
            {
                gecici = gecici + "*";
            }
            return gecici + _kredikart.Substring(_kredikart.Length - 2);
        }


}
}
