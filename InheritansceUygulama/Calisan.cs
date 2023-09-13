using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritansceUygulama
{
    public class Calisan
    {

        private int id;
        private string isim;
        private string soyisim;

        public Calisan(int id, string isim ,string soyisim)
        {
            this.id = id;
            this.isim = isim;
            this.isim = soyisim;

        }

        public int getId()
        {
            return this.id;

        }
        public void setId(int id)
        {
            this.id = id;
        }

        public string getIsim()
        {
            return this.isim;
        }

        public void setIsim(string isim)
        {
            this.isim = isim;
        }

        public string getSoyisim()
        {
            return this.soyisim;
        }
        public void setSoyisim(string soyisim)
        {
            this.soyisim = soyisim;
        }

        public void BilgileriGoster()
        {
            Console.WriteLine("İD:"+ this.id);  
            Console.WriteLine("İSİM:"+this.isim);
            Console.WriteLine("SOYİSİM" + this.soyisim);

        }
    }

    


}
