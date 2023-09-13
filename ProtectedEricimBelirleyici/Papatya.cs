using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedEricimBelirleyici
{
    public class Papatya : Bitki //Papatya klası SubClass tır. Mirası alana SubClass denir.
    {
        public void papatyaBilgileri()
        {
            bitkiID = 1;
            bitkiIsmi = "Papatya";
            bitkiRengi = "Beyaz";


            Console.WriteLine("Bitki ID:" + bitkiID);
            Console.WriteLine("Bitki İsmi:" + bitkiIsmi);
            Console.WriteLine("Bitki Rengi:" + bitkiRengi);


        }


    }
}
