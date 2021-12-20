using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    public class Arac
    {
        public string Marka;
        public string Model;
        public int modelYıl;
        public int Km;
        public int yakıtTipi;
        public int vitesTipi;
        public int alısFiyat;
        public int satısFiyat;
        public int maxIndirim;
        public int Fiyat;


        public Arac()
        {

        }

        public Arac(string _marka, string _model)//kullanıcıdan gelen parametre
        {
            Marka = _marka;
            Model = _model;

        }
        public Arac(string _marka, string _model,int model_yıl)
        {
            Marka = _marka;
            Model = _model;
            modelYıl = model_yıl;

        }
        public Arac(string _marka, string _model, int model_yıl, int _km)
        {
            Marka = _marka;
            Model = _model;
            modelYıl = model_yıl;
            Km = _km;

        }

        public void fiyatAta(int _fiyat)
        {
           decimal Fiyathes = satısFiyat - maxIndirim;

            if (_fiyat > Fiyathes)
            {
                Console.WriteLine("satış gerçeklesmedı");
            }
            else  
            {
                this.Fiyat = _fiyat;
                Console.WriteLine(" satıs güncellendı");
            }

        }

        public void bilgilerigörüntüle()
        {
            Console.WriteLine("Marka{0}-Model{1}-Model yıl{2}",Marka,Model,modelYıl);

        }


    }



}
