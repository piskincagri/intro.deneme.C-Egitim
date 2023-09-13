using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritansceGiris
{
    public class Kedi : Kopek


    {
        public void sesCikar()
        {

            Console.WriteLine("Kedi ses çıkarıyor MİYAVVVV");
          
        }


        public void hayvanBilgileriGoster()
        {
            Console.WriteLine("Hayvan ismi: "+ isim );
            Console.WriteLine("Hayvanın rengi:" + renk);
            Console.WriteLine("Hayvanın kilosu:" + kilo);
            Console.WriteLine("Hayvan ayak sayısı:" + ayakSayisi);
            Console.WriteLine("Hayvanın Cinsiyeti:" + cinsiyet);
        }

       

        

    }
}
