using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeOdev
{
    public class Personel
    {
        private string tckimlikno;

        public string TCKIMLIKNO
        {

            get
            {
                return tckimlikno.Substring(0, 4)+"******";
            }   

            set
            
            {
                bool kontrol =false;

                if(value.Length==11)
                {

                    for (int i=0; i<value.Length; i++)
                    {

                        bool sayiMi = char.IsNumber(value[i]);

                        if(sayiMi )
                        {


                        }
                        else
                        {
                            kontrol=true;
                            break;

                        }
                    }

                    if (kontrol)
                    {

                        Console.WriteLine("TC kimlik numarasınızda geçersiz bir karakter bulundu.");

                     }

                    else
                    {
                        tckimlikno = value;

                    }


                }
                else
                {
                    Console.WriteLine("Girdiğiniz TC no hatalıdır. 11 karakterli bir TC no giriniz");
                }

               

                
            }

        }
      




    }
}
