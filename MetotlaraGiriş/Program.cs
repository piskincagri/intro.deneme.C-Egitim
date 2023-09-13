using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlaraGiriş
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parmetresiz -Geriye Değer Döndürmeyen Metot Tanımlama

            SelamVer();
            SelamVer();
            SelamVer();
            SelamVer();
            SelamVer();
            SelamVer();
            AdiniYazdir();


         }

        static void SelamVer()
        {
            Console.WriteLine("SELAMLAR:");
            


        }

        static void AdiniYazdir()
        {
            Console.WriteLine("Enes Bayram");
            Console.ReadLine(); 
        }
    }
}
