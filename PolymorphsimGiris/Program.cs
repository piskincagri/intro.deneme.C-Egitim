using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphsimGiris
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hayvan hayvan = new Hayvan("Hayvan");

            hayvan.konus();

            Kedi kedi = new Kedi("Minnoş");

            kedi.konus();

            Kopek kopek = new Kopek("Karabaş");

            kopek.konus();

            Console.ReadLine();



        }

    }
}
