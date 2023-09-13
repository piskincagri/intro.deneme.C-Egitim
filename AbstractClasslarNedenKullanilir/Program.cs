using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasslarNedenKullanilir
{
    public class Program
    {
        static void Main(string[] args)
        {

            Ocak ocak = new Ocak();
            Console.WriteLine("Ocak Gün Saati:"+ocak.gunSaati());
            Console.WriteLine("Ocak Kaç gün?:"+ocak.kacAyCekiyor());
            Console.WriteLine("Ocak Kaçıncı Ay:"+ocak.kacinciAy());
            Console.WriteLine(" ");

            Subat subat = new Subat();
            Console.WriteLine("Şubat Gün Saati:"+subat.gunSaati());
            Console.WriteLine("Şubat Kaç gün?:" + subat.kacAyCekiyor());
            Console.WriteLine("Mart Kaçıncı Ay:" + subat.kacinciAy());
            Console.WriteLine(" ");

            Mart mart = new Mart();
            Console.WriteLine("Mart Gün Saati:"+mart.gunSaati());
            Console.WriteLine("Mart Kaç gün?:" + mart.kacAyCekiyor());
            Console.WriteLine("Mart Kaçıncı Ay:" + mart.kacinciAy());
            Console.WriteLine(" ");

            Console.ReadLine();

        }
    }
}
