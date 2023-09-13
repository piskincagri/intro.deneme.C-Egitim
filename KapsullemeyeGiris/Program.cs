using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeyeGiris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //geter seter metotlar
            //property ile

            Ogrenci ogrenci1 = new Ogrenci();

            ogrenci1.setIsim("ENES");
            string gelenIsim=ogrenci1.getIsim();

            if(gelenIsim == "ENES")
            {
                Console.WriteLine("İsmi Enestir");
            }
            else
            {
                Console.WriteLine("İsim hatalıdır.");
            }

            Console.ReadLine(); 





        }
    }
}
