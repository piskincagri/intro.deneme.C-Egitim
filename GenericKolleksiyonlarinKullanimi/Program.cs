﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKolleksiyonlarinKullanimi
{
    public class Program
    {
        static void Main(string[] args)
        {

           /* List<int> rakamlar = new List<int>();

            rakamlar.Add(0);
            rakamlar.Add(1);
            rakamlar.Add(2);
            rakamlar.Add(3);
            rakamlar.Add(4);
            rakamlar.Add(5);
            rakamlar.Add(6);
            rakamlar.Add(7);
            rakamlar.Add(8);
            rakamlar.Add(9);
            foreach (int rakam in rakamlar)
            {
                Console.WriteLine(rakam);
                
            }
            Console.ReadLine();*/


            List<Musteri> musteriler = new List<Musteri>();

            musteriler.Add(new Musteri(1,"Çağrı","PİŞKİN","cagri.piskin@icloud.com"));
            musteriler.Add(new Musteri(2,"KERİME","PİŞKİN","kerimeer@gmail.com"));
            musteriler.Add(new Musteri(3, "DELFİN", "PİŞKİN", "delfin.piskin@gmail.com"));


            foreach(Musteri musteri in musteriler)
            {

                Console.WriteLine(musteri);
            }
            Console.ReadLine();
        }   
    }
}
