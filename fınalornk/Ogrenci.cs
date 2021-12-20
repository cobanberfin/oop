using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fınalornk
{
    public class Ogrenci
    {
        int sayi;
        public Ogrenci()
        {
            Random rnd = new Random();
                sayi = rnd.Next(1000, 9000);
            
        }

        private string _ogrNO;
        
        public string ogrNO {

            get
            {
              string d=  Bölüm.Substring(0, 1).ToUpper() + Sınıf + sayi;
                _ogrNO = d;
                return _ogrNO;


                ; }
        private    set { _ogrNO = value; }
        
        
        
        }



        public string Ad{ get; set; }
        public string Soyad { get; set; }


        public string Bölüm { get; set; }




        //set { _bölüm = value.Substring(0, 1).ToUpper() + value.Substring(1); }



        public string Sınıf{ get; set; }



    }
}
