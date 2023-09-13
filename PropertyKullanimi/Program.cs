using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyKullanimi
{
     class Program
    {
        static void Main(string[] args)
        {
            //Property Nedir? (Özellik)

            Musteri musteri1 =new Musteri();
            musteri1.KILO = 85; ///Değer atama yapılıyor Set Blokları çalışır.
            //eğer derer ataması yapılmazsa GEt bloku çalışır.

            Console.WriteLine(musteri1.KILO);
            //eğer değer ataması yapılmasaydı o zaman get blokları çalışırdı


            Console.ReadLine();
        }
    }
}
