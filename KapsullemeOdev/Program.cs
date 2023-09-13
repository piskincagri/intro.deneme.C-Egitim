using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Personel P1 = new Personel();

            P1.TCKIMLIKNO = "12345678956";

            Console.WriteLine("Tc Kimlik numaranız:"+ P1.TCKIMLIKNO);

            Console.ReadLine();
        }
    }
}
