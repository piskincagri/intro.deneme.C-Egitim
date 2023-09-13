using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Kullanıcıdan aldığımız sayinın karesini alalım eğer karesi 25'ten büyükse;
            ///karesi 25'ten büyüktür.
            ///değilse 25'ten küçüktür. yazdırsın


            Console.WriteLine("Bir sayi giriniz:");

            int sayi = int.Parse(Console.ReadLine());
            int KareDeger = KareAl(sayi);
            if (KareDeger >25) 
            {
                Console.WriteLine("Girmiş olduğunuz sayının Karesi 25'den büyüktür");
            
            }
            else
            {
                Console.WriteLine("Girmiş olduğunuz sayının Karesi 25'den küçüktür");
            }
            Console.ReadLine();



        }

        static int KareAl(int a)
        {

            return a * a;

        }
    }
}
