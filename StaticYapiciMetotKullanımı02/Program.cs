using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticYapiciMetotKullanımı02
{
     class Program
    {
        static void Main(string[] args)
        {
            Kullanici K1 = new Kullanici(1,"Çağrı","Pişkin");

            K1.bilgileriGoster();
            K1.zamYap(5000);

            Console.ReadLine();



        }
    }
}
