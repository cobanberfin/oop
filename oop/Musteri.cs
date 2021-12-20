using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
   public class Musteri
    {
        /*
         tc,isim,soyisim,cınsıyet
         
         */

        public string Tc;
        public string isim;
        public string soyisim;
        public int cinsiyet;//777100101:erkek 777100102::kadın

        public Musteri() //ctor hıc dokunmazsan varsayılan
        {
            Tc = "1234587635";// diğer halını ezdım git bunu kulan ddedım
        }


        public Musteri(string _tc) //overload gıbı kullanıcam
           
        {
            Tc=_tc;
        }
        public Musteri(string _tc,string _isim) //overload gıbı kullanıcam

        {
            Tc = _tc;
            isim = _isim;
        }

        public Musteri(string _tc, string _isim,string _soyisim) //overload gıbı kullanıcam

        {
            Tc = _tc;
            isim = _isim;
            soyisim = _soyisim;
        }


        public bool MusteriKontrol()
        {
            bool kontrol = MusteriKontroldatabase( Tc);
            return kontrol;
        }
        private bool MusteriKontroldatabase(string tc)
        {
            //databasede bu tc kımlık numaralı kısı varmı kontrol ıslemı yap
            return true;
        }

    }
}
