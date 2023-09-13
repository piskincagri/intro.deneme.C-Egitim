using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritansceGiris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi();
            kedi.isim = "Minnoş";
            kedi.kilo = "3";
            kedi.renk = "Gri";
            kedi.cinsiyet = "dişi";
            kedi.ayakSayisi = 4;

            kedi.sesCikar();
            kedi.hayvanBilgileriGoster();

            Console.ReadLine();



        }
    }
}
