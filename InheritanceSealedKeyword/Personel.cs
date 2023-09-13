using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSealedKeyword
{
    public /*sealed*/ class Personel    //sealed anahtar kelimesi nedir?  bu eklenirse Kimse bu class ı miras alamaz!...
    {
        public int personel_id {  get; set; }

        public string  personel_ismi { get; set; }

        public string personel_soyismi { get; set; }

        public int personel_maas { get; set; }

        public void PersonelBilgileri()
        {

            Console.WriteLine("Personel id:"+ personel_id);
            Console.WriteLine("pERSONEL İSMİ:" + personel_ismi);
            Console.WriteLine("personel soyisim"+personel_soyismi); Console.WriteLine("Personel Maaş" + personel_maas);

        }
    }
}
