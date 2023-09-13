using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticYapiciMetotKullanimi
{
     class Program
    {
        static void Main(string[] args)
        {

           Calisan C1 = new Calisan();
            C1.CalisanID = 1;
            C1.isim = "Enes";
            C1.soyisim = "Bayram";
            Calisan.maas = 2500;

            Console.WriteLine("Çalışan ID:" + C1.CalisanID);
            Console.WriteLine("Çalışan İsim:" + C1.isim);
            Console.WriteLine("Çalışan Soyisim:" + C1.soyisim);
            Console.WriteLine("Çalışan Maaş:" + Calisan.maas);

            Console.ReadLine();


        }
    }
}
