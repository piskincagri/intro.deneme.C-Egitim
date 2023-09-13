using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumlarlaOrnekUygulama
{
    public class Musteri
    {

        public int id { get; set; }
        public string isim { get; set; }
        public string  soyisim { get; set; }
        public string cinsiyet { get; set; }
        public string emailAdres { get; set; }


        public static ArrayList musteriler =new ArrayList();

        public MusteriDurum MusteriEkle(Musteri M1)
        {
            musteriler.Add(M1);

            return MusteriDurum.kayitBasarili;

          

        }
    }
}
