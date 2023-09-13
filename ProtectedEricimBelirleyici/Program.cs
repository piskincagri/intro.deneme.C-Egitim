using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedEricimBelirleyici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Protected Erişim belirleyicisi tekrar
            // Super Class , Base Class == Mirası veren class
            //Sub Class == Alt Class


            Papatya papatya = new Papatya();

           
            papatya.papatyaBilgileri();

            Console.ReadLine();

        }
    }
}
