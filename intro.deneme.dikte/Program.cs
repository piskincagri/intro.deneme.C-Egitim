using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro.deneme.dikte
{   

    }
class Program
{
    static void Main(string[] args)


    #region//bir sayının iki katını alan program
    //kullanıcıdan bir değer girmesini iste
    //girilen sayı değerini oku
    //iki katını hesapla
    // sonucunu ekranda göster
    {
        //Console.WriteLine("Merhaba size ekrana gireceğiniz bir rakkamın iki katını hesaplayacağım.");

        //Console.WriteLine("Lütfen bir sayı giriniz");

        //string girilensayi = Console.ReadLine();

        //int girilensayidegeri = 0;

        //girilensayidegeri = int.Parse(girilensayi);

        //int sonuc = girilensayidegeri * 2;

        //Console.WriteLine("Girilen sayının iki katı sonucu :" + sonuc);

        //Console.ReadLine();
        #endregion

        #region Girilen sayının %15'ini hesaplayan program

        //Console.WriteLine("Merhaba sizelere bir sayı girmenizi istiyorum.");
        //Console.WriteLine("Girmiş olduğunuz sayının %15i ni hesaplayacağım.");
        //Console.WriteLine("Lütfen bir sayı giriniz:");
        //string girilensayi = Console.ReadLine();
        //int girilensayidegeri = 0;
        //girilensayidegeri = int.Parse(girilensayi);

        //int sonuc = girilensayidegeri * 15 / 100;
        //Console.Write("Girilen sayının %15i :" + sonuc);

        //Console.ReadLine();

        #endregion


        #region Bileşik faiz hesaplama programı

        // Kullanıcıdan yatıracağı ana para tutarını girmesini iste
        // Kullanıcıdan yatıralacak ana paranın ne kadar gün kalacağını girmesini iste
        // Kullanıcıdan faiz oranını girmesini iste
        // Bileşik faizi hesapla kullanıcıya göster

        //Console.WriteLine("Merhaba");
        //Console.WriteLine("Size mevduat hesabınıza yatıracağınız bakiyenin faizini öğrenmenezi sağlayacağım.");

        //Console.WriteLine("Lütfen Anapara tutarını giriniz:");
        //string anapara = Console.ReadLine();
        //Console.WriteLine("Lütfen faiz oranı giriniz:");
        //String faiz = Console.ReadLine();
        //Console.WriteLine("Lütfen gün sayısını giriniz");
        //string gün = Console.ReadLine();

        //int anapara1 = 0;
        //anapara1 = int.Parse(anapara);

        //int faiz1 = 0;
        //faiz1 = int.Parse(faiz);

        //int gün1 = 0;
        //gün1 = int.Parse(gün);

        //float sonuc = anapara1 * faiz1 * gün1 / 36500f;

        //Console.WriteLine("Mevduatınızın hesaplanan faizi" + " " + sonuc + "TL");

        //Console.ReadLine();

        #endregion

        #region Kullanıcı adı ve şifre sorma
        //Kullanıya kullanıcı adını sor
        //Kullanıcıya şifresini sor
        //Eğer kullanıcı sistemde tanımlı kullanıcı adı veya şifreyi girerse hoşgeldiniz de. 
        //Kullanıcı adı, şifre hatalı ise uyarı ver

        //    string kullaniciadi = "melike";
        //    string sistemsifresi = "123456";
        //    Console.WriteLine("Merhaba lütfen sisteme girmek için kullanıcı adınızı giriniz");
        //    Console.WriteLine("Kullanıcı adı:");
        //    string kull = Console.ReadLine().ToLower();

        //    Console.WriteLine("Lüften şifrenizi giriniz");
        //    Console.WriteLine("Şifre:");
        //    string sifre = Console.ReadLine();

        //    if (kull == kullaniciadi && sistemsifresi == sifre)
        //    {
        //        Console.WriteLine("Hoşgeldiniz. Sisteme girebilirsiniz...");
        //        Console.ReadLine();
        //    }

        //    else
        //    {
        //        Console.WriteLine("Kullanıcı adı veya şifre hatalı.Sisteme giremezsiniz...");
        //    }
        //    if (kull == "melike")
        //    {
        //        if (sifre == "123456")
        //        {
        //            Console.WriteLine("Hoşgeldiniz. Sisteme girebilirsiniz...");
        //            Console.ReadLine();
        //        }
        //        else
        //            Console.WriteLine("Kullanıcı adınız doğrudur. Ancak şifreniz yanlıştır...");
        //    }
        //    else
        //    {
        //        if (sifre == "123456")
        //        {
        //            Console.WriteLine("Girmiş olduğunuz kullanıcı adı yanlıştır...");
        //            Console.ReadLine();
        //        }
        //        else
        //        {
        //            Console.WriteLine("Girmiş olduğunuz kullanıcı adı ve şifre yanlıştır...");
        //            Console.ReadLine();
        //        }
        //    }

        #endregion


        #region İsim sorarak sisteme giriş yaptırma
        //Console.WriteLine("Lütfen isminizi giriniz");
        //string kullaniciadi = Console.ReadLine();

        //switch (kullaniciadi)
        //{
        //    case "arda":
        //        Console.WriteLine("Hoşgeldin Arda");
        //        Console.WriteLine("nasılsın?");
        //        Console.ReadLine();
        //        break;

        //    case "cagri":
        //        Console.WriteLine("Merhaba Çağrı");
        //        Console.WriteLine("Nasılsın?");
        //        Console.ReadLine();
        //        break;

        //    default:

        //        Console.WriteLine("Girdiğiniz kullanıcı adı hatalıdır.");
        //        Console.ReadLine();
        //        break;
        //}

        #endregion

        #region 4 İŞLEM HESAP MAKİNESİ PROGRAMI

        //Console.WriteLine("Merhaba ben bir 4 işlem hesap makinesiyim");
        //Console.WriteLine("Girmiş olduğunuz sayılar ile size 4 işlem hesaplama yapacağım");
        //Console.WriteLine("Lüfren 1. sayıyı giriniz");
        //int girilenilksayi = int.Parse(Console.ReadLine());

        //Console.WriteLine("Lütfen 4. işlem seçiminizi seçiniz  +  -  *  /");
        //char islem = char.Parse(Console.ReadLine());

        //Console.WriteLine("Lütfen 2. sayıyı giriniz");
        //int girilenikincisayi = int.Parse(Console.ReadLine());

        //switch (islem)
        //{
        //    case '+':
        //        Console.WriteLine("Toplama işleminin sonucu  " + (girilenilksayi + girilenikincisayi));
        //        Console.ReadLine();
        //        break;
        //    case '-':
        //        Console.WriteLine("Çıkarma işleminin sonucu" + (girilenilksayi - girilenikincisayi));
        //        Console.ReadLine();
        //        break;

        //    case '*':
        //        Console.WriteLine("Çarpma işleminin sonucu" + (girilenilksayi * girilenikincisayi));
        //        Console.ReadLine();
        //        break;
        //    case '/':
        //        Console.WriteLine("Bölme işleminin sonucu" + (girilenilksayi / girilenikincisayi));
        //        Console.ReadLine();
        //        break;

        //    default:
        //        Console.WriteLine("Hatalı işlem karakteri girdiniz. Lüten sadece +  - * / kullanınız...");
        //        Console.ReadLine();
        //        break;

        #endregion

        #region // VÜCUT KİTLE ENDEKSİ HESAPLAMA PROGRAMI

        //// Öncelikle VKE nedir kısa bir açıklama yap
        //// daha sonra kullanıcının boyunu sor
        //// daha sonra kullanıcının kilosunu sor
        //// VKE Hesaplayarak sonucu kullanıya bildir
        //{
        //    Console.WriteLine("Merhaba sağlıklı günler dilerim");
        //    Console.WriteLine();
        //    Console.WriteLine("Şimdi eğer isterseneniz Vucut kitle endeksinizi hesaplamak istiyorum");
        //    Console.WriteLine();
        //    Console.WriteLine("Öncelikle Vücut kitle endeksi nedir? Kısaca açıklamak istiyorum.");
        //    Console.WriteLine();
        //    Console.WriteLine("Vücut kitle endeksi, boy kilo endeksi olarak da bilinen, kişinin ağırlık ve boy değerleri kullanılarak hesaplanan bir sayıdır. Formülde kullanılan vücut ağırlığı, kilogram, boy ise metre cinsinden alınarak hesaplama yapılır. Vücut kitle endeksi hesaplama sonucunda çıkan değer ile kişinin zayıf, normal ağırlıkta, hafif şişman ya da obez olması gibi bir sınıflama yapılır. Fakat bu değer ile vücut yağ oranı ölçülmez. Yağ, kas, su gibi değerlerin miktarları belirlemede sadece genel bir tablo çizilmiş olur. Ana kullanım amacı kişinin boyuna göre sağlıklı vücut ağırlığında olup olmadığını belirlemektir. Kısaca vücut kitle indeksi, kişinin fazla kilolu ya da zayıf olduğunu gösteren bir ölçüttür; fakat vücut içerisindeki yağ, kas gibi değerleri bize vermez.");
        //    Console.WriteLine();

        //    Console.WriteLine("Lütfen kilonuzu giriniz:");
        //    string kilo = Console.ReadLine();

        //    Console.WriteLine("Lütfen boyunuzu giriniz:");
        //    string boy = Console.ReadLine();

        //    float girilenboy = 0;
        //    girilenboy = float.Parse(boy);
        //    float girilenkilo = 0;
        //    girilenkilo = float.Parse(kilo);


        //    float sonuc = girilenkilo / ((girilenboy) * (girilenboy));


        //    if (sonuc < 18.5)
        //    {
        //        Console.WriteLine("Zayıfsınız!" + "  " + " Vücut Kitle Endeksiniz:"+sonuc);

        //    }
        //    else if (sonuc >= 18.5 && sonuc <= 24.9)
        //    {
        //        Console.WriteLine("Normal ağırlıktasınız." + "  " + " Vücut Kitle Endeksiniz:" +sonuc);

        //    }
        //    else if (sonuc >= 25.0 && sonuc <= 29.9)
        //    {
        //        Console.WriteLine("Kilolusunuz." + "  " + " Vücut Kitle Endeksiniz:" + sonuc);

        //    }
        //    else if (sonuc >= 30.0 && sonuc <= 34.9)
        //    {
        //        Console.WriteLine("1.Derece Obezitesiniz." + "  " + " Vücut Kitle Endeksiniz:" + sonuc + " " + "Lütfen doktorunuza başvurunuz!..");

        //    }
        //    else if (sonuc >= 35.0 && sonuc <= 39.9)
        //    {
        //        Console.WriteLine("2.Derece Obezitesiniz." + "  " + " Vücut Kitle Endeksiniz:" + sonuc + " " + "Lütfen doktorunuza başvurunuz!..");

        //    }
        //    else if (sonuc >= 40.0 && sonuc <= 1000)
        //    {
        //        Console.WriteLine("3.Derece Obezitesiniz." + "  " + " Vücut Kitle Endeksiniz:" + sonuc + " " + "Lütfen doktorunuza başvurunuz!..");

        //    }
        //    Console.WriteLine("");

        //    Console.WriteLine("Not: Burada verilen sonuçlar sadece bilgilendirme amaçlıdır. Sayfa içeriğinde tedavi edici sağlık hizmetine yönelik bilgiler içeren ögelere yer verilmemiştir. Tanı ve tedavi için mutlaka hekiminize başvurunuz.");



        //    Console.ReadLine();


        #endregion

        #region  YIldız yapma

        //for (int i = 1; i <= 9; i++)
        //   {
        //       if (i <= 4 || i > 5)
        //       {
        //           Console.Write("*");
        //       }
        //       else
        //       {
        //           Console.WriteLine();
        //       }

        //   }

        //   Console.ReadKey();
        #endregion

        #region

        //for (int i = 1; i <= 9; i++)
        //{
        //    if (i <= 4 || i > 5)
        //    {
        //        Console.Write("*");
        //    }
        //    else
        //    {
        //        Console.WriteLine();
        //    }
        //    Console.ReadKey();
        //}
        #endregion

        #region/// ATM Uygulaması
        //// 1 e basarsa Bakiye görsün
        //// 2 e basarsa Para çeksin
        ////3 e basarsa Para yatırsın
        //// Q ya basarsa çıkış yapsın
        ////

        //Console.WriteLine("Merhaba ATM'ye hoşgeldiniz.");
        //Console.WriteLine("Lüfen kullanıcı adını giriniz");

        //int hak_Sayisi = 3;
        //decimal bakiye = 0m;
        //while (true)
        //{
        //    Console.WriteLine("Kullanıcı Adı:");
        //    string kullaniciadi = Console.ReadLine();
        //    Console.WriteLine("Kullanıcı Şifresi:");
        //    string sifre = Console.ReadLine();

        //    if (kullaniciadi == "Çağrı" && sifre == "123")
        //    {
        //        Console.WriteLine("Hoşgeldiniz");
        //        Console.ReadLine();


        //        bool devam = true;

        //        while (devam)
        //        {
        //            Console.WriteLine("Lütfen yapmak istedğiniz işlemi aşağıda belirtilen rakkamlar ile belirtiniz");
        //            Console.WriteLine("1 - Bakiye Sorma");
        //            Console.WriteLine("2- Para Çekme");
        //            Console.WriteLine("3 - Para Yatırma");
        //            Console.WriteLine("Q - Çıkış");
        //            Console.WriteLine("Lütfen yapmak istediğiniz işlemi tuşlayınız");

        //            string secim = Console.ReadLine();
        //            if (secim == "1")
        //            {
        //                Console.WriteLine("Şuanki bakiyeniz:" + bakiye.ToString("#.##0.00") + "'dir.");
        //                Console.ReadLine();
        //            }
        //            else if (secim == "2")
        //            {

        //                Console.WriteLine("Çekmek istediğiniz bakiyeyi giriniz:");
        //                decimal cekilecek_tutar = Convert.ToDecimal(Console.ReadLine());
        //                if (cekilecek_tutar <= bakiye)
        //                {
        //                    Console.WriteLine("Lütfen paranızı para çekme gözünden alınız");
        //                    bakiye = bakiye - cekilecek_tutar;
        //                    Console.WriteLine("Kalan bakiyeniz:" + " " + (bakiye.ToString("#.##0.00")) + "dir");
        //                    Console.ReadLine();
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Bakiyeniz Yetersizdir.");
        //                    Console.WriteLine("Güncel Bakiyeniz:" + bakiye.ToString("#.##0.00") + "dir.");
        //                    Console.ReadLine();
        //                }
        //            }
        //            else if (secim == "3")
        //            {

        //                Console.WriteLine("Lütfen yatırmak istediğiniz paranızı para yatırma gözüne yerleştiriniz");
        //                Console.WriteLine("Yatırılacak tutarı giriniz:");
        //                decimal yatirilacak_tutar = Convert.ToDecimal(Console.ReadLine());
        //                Console.WriteLine("Paranız hesabınıza yatmıştır.");
        //                bakiye = bakiye + yatirilacak_tutar;
        //                Console.WriteLine("Güncel Bakiyeniz " + (bakiye.ToString("#.##0.00")) + "dir.");
        //                Console.ReadLine();
        //            }
        //            else if (secim == "Q")
        //            {
        //                Console.WriteLine("Başka bir işlem yapmak istiyor musunuz? (E/H)");
        //                string cevap = Console.ReadLine();
        //                if (cevap == "H")
        //                {
        //                    Console.WriteLine("Program sonlandı.");
        //                    Console.ReadLine();

        //                }
        //                else if (cevap == "E")
        //                {
        //                    devam = true;

        //                }

        //            }

        //            else
        //            {
        //                Console.WriteLine("Lütfen gerçeli bir değer giriniz");
        //                Console.ReadLine();
        //                devam = true;
        //            }

        //        }
        //        break;
        //    }

        //    else
        //    {
        //        Console.WriteLine("Kullanıcı adı hatalı lütfen tekrar deneyiniz.");
        //        if (hak_Sayisi > 0)
        //        {
        //            hak_Sayisi -= 1;
        //        }
        //        if (hak_Sayisi == 0)

        //        {
        //            Console.WriteLine("Şifrenizi 3 kere hatalı girdiniz.");
        //            Console.WriteLine("Hesaba erişim engellenmiştir. Lütfen bağlı olduğunuz şubenize gidiniz.");

        //            break;

        //        }

        //    }

        //}
        //Console.ReadLine();

        #endregion

        #region// METHODLAR

        // PARAMETRESİZ- GERİYE DEĞER DÖNDÜRMEYEN METOT TANIMLAMA





        #endregion






    }






}