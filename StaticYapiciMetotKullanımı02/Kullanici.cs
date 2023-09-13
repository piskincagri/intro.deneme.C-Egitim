using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticYapiciMetotKullanımı02
{
    public class Kullanici
    {
        private int kullaniciID { get; set; }
        private string isim { get; set; }    
        private string soyisim { get; set; }
        private static int maas { get; set; }


        static Kullanici()
        {
            maas = 25000;


        }



        public  Kullanici(int  kullaniciid , string isim, string soyisim)
        {
            kullaniciID = kullaniciID;
            isim = isim;
            soyisim = soyisim;
          

        }

        public void bilgileriGoster()
        {

            Console.WriteLine("Kullanıcı Bilgileri:");
            Console.WriteLine("İd:" + kullaniciID);
            Console.WriteLine("İsim:" + isim);
            Console.WriteLine("Soyisim:" + soyisim);
            Console.WriteLine("Maaş:"+ maas);
        }

        public void zamYap(int zamMiktari)
        {

            Console.WriteLine("Kullanıcıya Zam Yapılıyor....");

            Console.WriteLine("Şuanki maaşı:" + (maas+zamMiktari));
        }



    }
}
