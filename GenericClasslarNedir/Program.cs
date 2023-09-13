using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasslarNedir
{
    public class Program
    {
        static void Main(string[] args)
        {

            RepoSitory<Musteri> repositoryMusteri = new RepoSitory<Musteri>();

            List<Musteri> musterilerim = repositoryMusteri.getir();


            Musteri musteri = new Musteri();
            musteri.id = 1;
            musteri.isim = "Çağrı";
            musteri.soyisim = "Pişkin";
            musteri.email = "cagri.piskin@icloud.com";

            repositoryMusteri.ekle(musteri);

            RepoSitory<Urun> repositoryUrun =new RepoSitory<Urun>();

            List<Urun> urunlerim= repositoryUrun.getir();

            Urun urun = new Urun();
            urun.urunİD = 1;
            urun.urunAdi = "Ram bellek";
            urun.urunFiyari = 1000;

           string cikti= repositoryUrun.ekle(urun);

            Console.WriteLine(cikti);

            Console.ReadLine();
        }
    }
}
