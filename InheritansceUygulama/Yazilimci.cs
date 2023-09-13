using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritansceUygulama
{
    public class Yazilimci:Calisan
    {

        private string diller;
        

        public Yazilimci(int id, string isim,string soyisim, string diller):base(id,isim,soyisim)
        {

            this.diller = diller;

        }

        public void formatAt(string isletimSistemi)
        {
            Console.WriteLine(getIsim() + "şuanda " + " " + isletimSistemi + "işletim sistemine format atıyor");


        }

    }
}
