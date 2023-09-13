using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKolleksiyonlarinaGiris
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*
             * BURADA HER TİPDE DEĞER KABUL EDİLİYOR İNT, STRİNG, DOUBLE BU 
             * İLKEL YÖNTEM
             * ArrayList kolleksiyon = new ArrayList();

            kolleksiyon.Add(1);
            kolleksiyon.Add("ÇAĞRI");
            kolleksiyon.Add(3.5);

            */

            //Burada ise sadece istediğimiz veri tipindeki değeri girmemize olanak sağlıyor. İstenmeyen veri tipi girildiğinde hata veriyor.

            degerEkle(5);


        }

         static void degerEkle(int deger)//Burada değer girilmesi istenen veri tipi belirleniyor.
        {
            ArrayList kolleksiyon = new ArrayList();
            kolleksiyon.Add(deger);
        }

      

    }
}
