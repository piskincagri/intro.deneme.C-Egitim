using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSealedKeyword
{
    public class Program
    {
        static void Main(string[] args)
        {

            //sealed anahtar kelimesi nedir?  Kimse bu class ı miras alamaz!...


            Musteri musteri = new Musteri();

            musteri.personel_id = 1;
            musteri.personel_ismi = "ENES";
            musteri.personel_soyismi = "BAYREM";
            musteri.personel_maas = 25000;

            musteri.PersonelBilgileri();

            Console.ReadLine();
           
        }
    }
}
