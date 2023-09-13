using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBelirliyiciler
{
    public class Ogrenci
    {
        private int id = 1;
        private string isim = "ENES";
        public string soyisim = "BAYRAM";
        public string okul = "DOĞUŞ ÜNV";

        private void adSoyadYazdir()
        {
            Console.WriteLine("Adı:" + isim, "SOYADI:" + soyisim);


        }

        public void okulYazdir()
        {
            Console.WriteLine("Okul adı:" + okul);

        }



    }
}
