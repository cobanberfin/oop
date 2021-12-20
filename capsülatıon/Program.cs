using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capsülatıon
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
             fiel değer atması yapılmasın ama değer okunsun.
            filed değer atamsı ve okuma işlemlerı yapılsın ama bu ıkı ıslemde bizim belirlediğimiz bir sürecten geçsin verı daha sonra gösterılsın
            field değer atamsı yapılsın ama deger okunmasın
            field deger atması yapılsın ama değerın ilk 3 hanesı okunsun

            
             
             */
            Musteri m = new Musteri();
            m.isim = "gül";
            m.isim = "yılmaz";
            Console.WriteLine(m.email);
            Console.WriteLine("tc girin");
            m.TC = Console.ReadLine();
            m.TC = "8863353461";
            //m.id=24235; seti prıvta yaptıgım zı ıcn degr atamz
            Console.WriteLine(m.id);
            Console.WriteLine(m.TC);
            Console.ReadLine();








        }
    }
}
