using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicvePrivateErisimBelirliyicileri
{
    public class Musteri
    {
        public string isim;
        public string soyisim;
        public int maasDegeri;
        public string cinsiyet;
        private int yas;


        public Musteri()
        {
            Console.WriteLine("Müşteri sınıfının yapıcı metodu çalıştı");
           
        }

        public void musteriBilgileriGoster()
        {

            Console.WriteLine("İsmi:" + isim);
            Console.WriteLine("Soyismi:"+soyisim);
            Console.WriteLine("Maaş:" + maasDegeri);
            Console.WriteLine("Cinsiyet:" + cinsiyet);
            Console.WriteLine("Yaş Değeri:" + yas);

        }


        private void IsimSoyisimYazdir(string musteriisim, string musterisoyisim)
        {
            Console.WriteLine("Müşterinin İsim ve Soyismi:" + musteriisim + "  " + musterisoyisim);



        }



    }
}
