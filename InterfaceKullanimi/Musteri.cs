using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceKullanimi
{
    public class Musteri : IMusteri,IPersonel
    {
        public void ekle()
        {
            Console.WriteLine("Müşteri eklendi");
        }

        public void getir()
        {
            Console.WriteLine("Müşteri getirildi");
        }

        public void guncelle()
        {
            Console.WriteLine("Müşteri güncellendi");
        }

        public void PersonelEkle()
        {
            Console.WriteLine("Personel eklendi");
        }

        public void sil()
        {
            Console.WriteLine("Müşteri silindi");

        }

       
    }
}
