using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumlarlaOrnekUygulama
{
    public class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri = new Musteri();
            musteri.id = 1;
            musteri.isim = "ÇAĞRI";
            musteri.soyisim = "Pişkin";
            musteri.cinsiyet = "Erkek";
            musteri.emailAdres = "cagri.piskin@icloud.com";

            MusteriDurum donenDurum= new MusteriDurum();

            if(donenDurum==MusteriDurum.kayitBasarili)
            {
                Console.WriteLine("Müşteri başarlı bir şekilde kayıt edilmiştir.");


            }

            Console.ReadLine();


        }


    }
}
