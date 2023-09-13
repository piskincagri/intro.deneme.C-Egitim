using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace InheritansceUygulama
{
    public class Yonetici: Calisan
    {
        private int sorumluKisiSayisi;
        public Yonetici(int id, string isim, string soyisim, int sorumluKisiSayisi ): base (id, isim, soyisim ) 
        
        { 
            this.sorumluKisiSayisi = sorumluKisiSayisi;


        }

        public void zamYap(int zamMiktari)
        {
            Console.WriteLine(getIsim() + " " + zamMiktari + " " + "TL Çalışanlara zam yapılıyor");

        }


    }
}
