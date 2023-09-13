using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarOrnek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan alınan sayı tek mi çift mi olduğunu bulan metot yazalım...
            Console.Write("Bir sayı giriniz:");
            int girlenSayi= int.Parse(Console.ReadLine());

            tekMiCiftMi(girlenSayi);

            Console.ReadLine();



        }

        static void tekMiCiftMi (int sayi)
        {

            if (sayi %2 == 0)
            {
                Console.WriteLine("Sayi Çifttir");
            }
            else
            {
                Console.WriteLine("Sayı Tektir");
            }
        }
    }
}
