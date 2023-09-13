using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametreliMetotTanımlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parametre Alan-Geriye Değer Döndürmeyen Metot Yazma
            toplamaYap(5,7);

            Console.ReadLine();

            carpmaYap(5, 7, 10);
            Console.ReadLine();

            isimSoyisimYazdir("Çağrı","Pişkin");
            Console.ReadLine();


        }

        static void toplamaYap(int sayi1, int sayi2)
        {
            Console.WriteLine("Gönderilen sayıların toplamı:"+ (sayi1+sayi2));

        }

        static void carpmaYap(int sayi1, int sayi2 , int sayi3)
        {

            Console.WriteLine("Gönderilen sayıların çarpımı" + (sayi1 * sayi2 * sayi3));
        }

        static void isimSoyisimYazdir(string isim, string soyisim)
        {
            Console.WriteLine("İsim ve soyisim:"+ isim+" "+ soyisim);
        }


    }
}
