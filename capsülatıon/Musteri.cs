using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capsülatıon//private onune koylan proprty sayesınde duzenleem yapılıyordu
{
    public class Musteri
    {
        public Musteri()//program yuklenırken cgr
        {
            IdAtama();
        }
        private int _id;
        public int id { get { return _id; } private set {; } } //ıd edegr atanamz

        private int IdAtama()
        {
            Random rnd = new Random();
            _id = rnd.Next(1000, 9000);
            return _id;

        }

        public string isim { get; set; }
        private string _soyisim;
        public string soyisim
        {
            get { return _soyisim; }

            set
            {
                _soyisim = value;
                _email = string.Format("{0}.{1}@gamil.com", isim, _soyisim);

            }

        }
        private string _email;
        public string email { get { return _email; } set { _email = value; } }

        private string _TC;
        public string TC { 
        
            get
            {


                int sayi = (_TC.Substring(3)).Length;
                string tc = "";
                for (int i = 0; i < sayi; i++)
                {
                    tc = tc + "*";
                }

                return _TC.Substring(0, 3) + tc;//ilk3 göster yanına devamını tc yıyaz



                ; }



            set
            {
                if (value.Length == 11)
                {
                    bool kontrol = false;
                    for (int i = 0; i <value.Length ; i++)
                    {
                        bool karakterkontrol = char.IsNumber(value[i]);
                        if (karakterkontrol)
                        {
                            //sayısal değer
                        }
                        else {
                            kontrol = true;
                            break;

                        }
                    }

                    if (kontrol)
                    {
                        Console.WriteLine("tc sayılardan oluşmalı");
                    }
                    else
                    {
                        _TC = value;
                    }
                }
                else
                {
                    _TC = value;
                }


            }


        }
    }
}