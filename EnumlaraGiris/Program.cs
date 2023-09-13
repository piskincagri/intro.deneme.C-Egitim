using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumlaraGiris
{
    public class Program
    {
        static void Main(string[] args)
        {

            Gunler gun =Gunler.Pazartesi;

            if(gun==Gunler.Pazartesi)
            {

                Console.WriteLine("Gün Pazartesidir.");
            }
            else if (gun == Gunler.Sali)
            {

                Console.WriteLine("Gün Salıdır.");
            }
            else if (gun == Gunler.Carsamba)
            {

                Console.WriteLine("Gün Çarşamabadır.");
            }
            else if (gun == Gunler.Perşembe)
            {

                Console.WriteLine("Gün Perşembedir.");
            }
            else if (gun == Gunler.Cuma)
            {

                Console.WriteLine("Gün Cumadır.");
            }
            else if (gun == Gunler.Cumartesi)
            {

                Console.WriteLine("Gün Cumartesidir.");
            }
            else if (gun == Gunler.Pazar)
            {

                Console.WriteLine("Gün Pazardır.");
            }
            else
            {

                Console.WriteLine("Lütfen geçeli bir değer giriniz");
            }
            Console.ReadLine();
        }
    }
}
