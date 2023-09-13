using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GeriyeDegerDondurenMetotTanımlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Parametre alan- Geriye Değer Döndüren Metot Tanımlama
            ////Return anahtar kelimesi
            ////metot sonu.

            //int DonenDeger = toplamaYap(6, 7);
            //if(DonenDeger>10)
            //{
            //    Console.WriteLine("Değer 10 dan büyüktür");

            //}
            //else
            //{
            //    Console.WriteLine("Değer 10'dan küçüktür");
            //}
            //Console.ReadLine();


            string GelenIsimSoyisim = isimSoyisimDondur("Çağrı", "Pişkin");
            Console.WriteLine(GelenIsimSoyisim);

            Console.ReadLine(); 
             
        }

        static int toplamaYap(int sayi1, int sayi2)
        {
            int sonuc =sayi1 + sayi2;
            return sonuc;
        }

        static string isimSoyisimDondur(string isim, string soyisim)
        {
            return isim + " " + soyisim;
        }




    }
}
