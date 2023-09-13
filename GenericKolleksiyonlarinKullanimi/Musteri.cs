using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKolleksiyonlarinKullanimi
{
    public class Musteri
    {

        public int ID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string email { get; set; }

        public Musteri(int id, string isim, string soyisim, string email)
        {
            this.ID = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.email = email;
        }

             public override string ToString()
             {
            return "id:" + this.ID + " " + "isim:" + this.isim + " " + "soyisim:" + this.soyisim + " " + "email:" + this.email;
              }
    
         
    }
  }
    

