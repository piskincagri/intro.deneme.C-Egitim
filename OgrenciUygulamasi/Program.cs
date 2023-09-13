using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool kontrol = true;  

            Ogrenci ogrenci1 = new Ogrenci(1, "Çağrı", "Pişkin", 50,40,73,"Dokuz Eylül Ünv");

            Console.WriteLine("Uygulamamıza Hoşgeldiniz.. Yapmak istediğini işlemi seçiniz");


            


            while (kontrol)
            {
                islemleriGoster();

                string secim = Console.ReadLine();
                
                switch (secim)
                {
                    case "1":
                        ogrenci1.ogrenciBilgileriGoster();
                        break;
                    case "2":
                        double ogrenciOrtalama = ogrenci1.ogrenciNotuBul();
                        Console.WriteLine("Öğrencinin Ortalaması:"+ ogrenciOrtalama);
                        break;
                    case "3":
                        ogrenci1.okulGetir();
                        break;
                    case "4":

                        kontrol = false;
                        break;

                  }

            }
        }

        static void islemleriGoster()
        {

            Console.WriteLine("1- Öğrenci Bilgilerini Göster");
            Console.WriteLine("2- Öğrencinin Ortalamasını Göster");
            Console.WriteLine("3- Öğrencinin Okulunu Göster");
            Console.WriteLine("4- Çıkış");

        }
    }
}
