using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////ArrayList nedir?

            ArrayList koleksiyon = new ArrayList();

            koleksiyon.Add("ENES");
            koleksiyon.Add("ALİ");
            koleksiyon.Add("YUSUF");
            koleksiyon.Add("MEHMET");


            //koleksiyon.Remove("MEHMET"); Dizi içinde mehmeti kaldırır.

            //int count = koleksiyon.Count; Dizinin içinde kaç tane isim var onu gösterir

            //koleksiyon.Clear(); Dizinin içindeki tüm bilgileri kaldırır.

            //bool kontrol =koleksiyon.Contains("YUSUF"); Dizi içinde istenilen değer var ise True veya False cevap verir

            //int index =koleksiyon.IndexOf("MEHMET");  Mehmetin kaçıncı indeste olduğunu gösterir

            //koleksiyon.Insert(2, "ÇAĞRI"); İndex in 2 ci sırasına ÇAĞRI ismini ekler

            //koleksiyon.Reverse(); Diziyi ters çevirir. Tersten yazar


            /*rakkamlar.Sort diziyi küçükten büyüğe sıralar
           ArrayList rakkamlar = new ArrayList();
            rakkamlar.Add(5);
            rakkamlar.Add(3);
            rakkamlar.Add(1);
           rakkamlar.Add(100);
            rakkamlar.Add(2);

            rakkamlar.Sort(); // diziyi küçükten büyüğe sıralar

             foreach (int a in rakkamlar)
            {

                Console.WriteLine(a);
            }*/


            /*foreach(var a in koleksiyon)
             {


                 Console.WriteLine(a);
             }
             Console.WriteLine("Dizinin eleman sayısı:" + count);
             Console.WriteLine("Varmı? :"+ kontrol);
             Console.WriteLine(" Yusuf Kaçıncı İndexte?" + index);
            */

            int a = 10;

            string b = a.ToString();

            Console.ReadLine();





        }
    }
}
