using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOrnek3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 2 tane sayi alalım hangisi büyükse, büyük olan sayıyı ekrana yazdıralım...
            Console.Write("Lütfen birinci sayıyı giriniz:");

            int sayi1= int.Parse(Console.ReadLine());

            Console.Write("Lütfen ikinci sayıyı giriniz:");

            int sayi2 =int.Parse(Console.ReadLine());   

           HangisiBuyukKucuk(sayi1 , sayi2);
            Console.ReadLine();


        }


        static void HangisiBuyukKucuk (int a , int b)
        {
            if (a > b)
            {
                Console.WriteLine("Birinci sayi ikinci sayıdan büyüktür.");

            }
            else if (a==b)
            {
                Console.WriteLine("Sayılar eşittir.");
            }
            else
            {
                Console.WriteLine("Birinci sayı ikinci sayıdan küçüktür");
            }

        }





    }
}
