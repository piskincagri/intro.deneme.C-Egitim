using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritansceUygulama
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Çalışan, Yazılımcı, Yönetici

            Console.WriteLine("Çalışan uygulamasına hoşgeldiniz");
          


            while (true)
            {
                Console.WriteLine("1-Yazılımcı İşlemleri:");
                Console.WriteLine("2-Yönetici İşlemleri:");
                Console.WriteLine("Q - ÇIKIŞ");

                string secilenislem = Console.ReadLine();
                if (secilenislem == "Q" && secilenislem == "q")
                {
                    Console.WriteLine("Çıkış Yapıldı");
                    break;
                }
                else if (secilenislem=="1")
                    {

                    Yazilimci yazilimci = new Yazilimci(1, "ÇAĞRI", "PİŞKİN",   "C#,ADONET");
                   

                    while(true)
                    {
                        Console.WriteLine("Yazılımcı işlemi seçini:");
                        Console.WriteLine("1-Format At");
                        Console.WriteLine("2-Bilgileri Göster");
                        Console.WriteLine("3-Çıkış yap");
                        string yazilimciIslem = Console.ReadLine();
                        if (yazilimciIslem == "3")
                        {
                            Console.WriteLine("Yazılımcı menüsünden Çıkış yapılıyor");
                            break;

                        }
                        else if(yazilimciIslem=="1")
                        {

                            Console.Write("İşletim sistemi giriniz");
                            string isletimSistemi = Console.ReadLine();
                            yazilimci.formatAt(isletimSistemi);
                        }
                        else if (yazilimciIslem == "2")
                        {

                            yazilimci.BilgileriGoster();

                        }
                        else
                        {

                            Console.WriteLine("Lütfen geçerli bir işlem giriniz");
                        }

                    }
                
                }
                else if (secilenislem == "2")
                {

                    Yonetici yonetici = new Yonetici(3, "Yakup", "Rençper",12);
                   

                    while(true)
                    {
                        Console.WriteLine("Yönetici İşlemi Seçiniz");
                        Console.WriteLine("1-Zam yap");
                        Console.WriteLine("2-Yöneticinin Bilgilerini Göster");
                        Console.WriteLine("3-Çıkış yapınız");
                        string yoneticiIslem = Console.ReadLine();
                        if (yoneticiIslem == "3")
                        {

                            Console.WriteLine("Yönetici işlemlerinden çıkış yapılıyor");
                            break;
                        }
                        else if (yoneticiIslem == "1")
                        {
                            Console.Write("Zam miktarını giriniz");
                            int zamMiktari= Convert.ToInt32(Console.ReadLine());
                            yonetici.zamYap(zamMiktari);

                        }
                        else if ( yoneticiIslem == "2")
                        {
                            yonetici.BilgileriGoster();

                        }
                        else
                        {

                            Console.WriteLine("Lütfen geçerli bir değer giriniz");

                        }

                    }

                  

                }
                else
                {

                     Console.WriteLine("Lütfen geçerli bir değer giriniz");
                }


            }



        }
    }
}
