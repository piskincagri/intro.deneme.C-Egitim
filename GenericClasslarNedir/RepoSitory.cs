using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasslarNedir
{
    public class RepoSitory<T>
    {
        public List<T> getir()
        {

            //veritabanına git ilgili tabloda git oradan kayıtları getir

            return null;

        }

        public string ekle(T data)
        {
            //Veritabanına git ilgili tabloda T tipindeki datayı ekle
            return "DATA BAŞARLILI BİR ŞEKİLDE EKLENMİŞTİR.";
        
        }

    }
}
