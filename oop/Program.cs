using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
class Program
    {
        static void Main(string[] args)
        {
            //araç satıs
            //musteri,satış temsılcıx,arac,teklif,sipariş,fatura

            //Musteri m1 = new Musteri();
            //m1.Tc = "16994294315";
            //m1.isim = "gül";
            //m1.soyisim = "yılmaz";


            //Musteri m2 = m1;
            //m2.isim = "murat";
            //m1.Tc = "1234350";
            //m2 = null;
            //m1 = null;
            //m2 ve m1 e sen artık o noktaya bakmadedım heap bolgede o noktayı tutan bır deger kalmadıgından pointersız kalır ve ramden duser.garbe collector bunu alır ve sıler
            //string isim = m2.isim; //hata alırım .m2 ın musterı nesnesı oldugunu bılıyom ama nevlemediğim için buna ulaşamam



            Musteri m1 = new Musteri("2436557","leyla");
            m1.Tc = "16994294315";
            m1.isim = "gül";
            m1.soyisim = "yılmaz";


          bool kontrol=  m1.MusteriKontrol();

            /*aracadında class olşutur
             * marka,model,modelyıl,km,yakıt_tipi,vites_tipi,alış_fiyat,satıs_fiyat,max_indirim,fıyat
             * 
             * arac clasının 3 tane overloadu olcak
             * 1 varsayılan bos
             * 2 marka model
             * 3marka ,model model_yıl
             * 
             * 4marka ,model model_yıl
             * 
             * void bilgileri görüntüle() m1.soyıdsım----cw ekranda göster
             * void fiyatAta(fiyat)---fıyat degrı=satış_fıyatı- indirim_tutarı
             *
             
             */


            Arac A1 = new Arac("opel", "corsa", 2018, 50000);
            A1.alısFiyat = 28000;
            A1.satısFiyat = 32000;
            A1.maxIndirim = 1500;
            A1.fiyatAta(30000);
            A1.bilgilerigörüntüle();
            Console.ReadLine();
               
            





        }
    }
}
