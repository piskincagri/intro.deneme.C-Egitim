using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKullanimi
{
    public class Araba
    {
        public int kapiSayisi;
        public string arabaModel;

        public string arabaRengi;

        public Araba(int _kapiSayisi, string _arabamobel, string _arabaRengi)
        {
            kapiSayisi= _kapiSayisi;
            arabaModel= _arabamobel;
            arabaRengi= _arabaRengi;
            
        }

        public void motorCalistir()
        {
            Console.WriteLine("Motor çalışıyor");
        }
        public void kapilariKilitle()
        {
            Console.WriteLine("Kapılar kitlendi");
        }


    }
}
