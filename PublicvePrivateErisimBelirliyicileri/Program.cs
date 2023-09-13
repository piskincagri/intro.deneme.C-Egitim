using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicvePrivateErisimBelirliyicileri
{
     class Program
      {
        static void Main(string[] args)
        {

            //public -- private -- protected-- internal

            Musteri musteri1 = new Musteri();

            musteri1.isim = "Enes";
            musteri1.soyisim = "Bayram";
            musteri1.maasDegeri = 2500;
            musteri1.cinsiyet = "Erkek";
            //musteri1.yas = 25;

            musteri1.musteriBilgileriGoster();

            Console.ReadLine();






        }
      }
}
