using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme
{
   public class ogrenci
    {//kapsülleme :içerisnde saklamıs oldugumuz private bır fıeld ın onune koydugumuz bır propert sayesınde get ve set kullanarak değer atamsı yapabılır ve deger okuyabılırz

        private string _ad;

        public string Ad
        {
            get {;return _ad; }

            set
            {
                _ad = value.Substring(0, 1).ToUpper() + value.Substring(1);
            }
        
        
        }
        private string _Soyad;

        public string Soyad
        {
            get {; return _Soyad; }

            set
            {
                //_Soyad = value.ToUpper();
                _Soyad = value.Substring(value.Length - 2,2)+ value.Replace(value,"*");
            }


        }
        private long _TC;

        public long Tc
        {
            get {; return _TC; }

            set
            {
                _TC = Math.Abs(value);
               

            }


        }




    }
}
