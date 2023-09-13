using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticDegiskenKullanimi
{
     class Program
    {
        static void Main(string[] args)
        {
            //static değişken kullanımı
            Calisan C1 = new Calisan();

            C1.calisanID= 1;
            C1.isim = "Çağrı";
            C1.soyisim = "Pişkin";
            Calisan.maas = 2500;

            Console.WriteLine("Çalışan ID" + C1.calisanID);
            Console.WriteLine("Çalışan İsim" + C1.isim);
            Console.WriteLine("Çalışan soyisim" + C1.soyisim);
            Console.WriteLine("Çalışan Maaş"+Calisan.maas);

            Console.ReadLine();



        }
    }
}
