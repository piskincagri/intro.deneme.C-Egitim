using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMetotKullanimi
{
     class Program
    {
        static void Main(string[] args)
        {
            //static metot kullanımı
            //static değişken kullanımı
            //static yapıcı metot kullanımı
            //static class kullanımı


            //***Static olmadan Public Void olarak yapılırsa aşağıdaki gibi kod yazılmak zorunda kalınır.
            //Personel P1 = new Personel();
            //P1.isimSoyisimYazdir();

            //Console.ReadLine();


            Personel.isimSoyisimYazdir();

            

            Personel.sayilariTopla(5, 11);

            Console.ReadLine();




        }
    }
}
