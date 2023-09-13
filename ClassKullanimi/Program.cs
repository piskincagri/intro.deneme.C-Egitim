using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {

       


            Araba araba1 = new Araba(4,"RENAULT","KIRMIZI");

            Console.WriteLine("ARABANIN RENGİ:" + araba1.arabaRengi);
            Console.WriteLine("ARABA MODELİ:"+araba1.arabaModel );
            Console.WriteLine("ARABA RENGİ:"+araba1.arabaRengi);

            

            araba1.kapilariKilitle();
            araba1.motorCalistir();

            Console.WriteLine("Arabanın kapı sayısı:" + araba1.kapiSayisi);
            Console.WriteLine("Araba Rendi" + araba1.arabaRengi);
            Console.WriteLine("Araba Modeli"+  araba1.arabaModel);

            Console.ReadLine();


        }
    }
}
