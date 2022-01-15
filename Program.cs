using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary
            //Key Ve Valu Tipinde Veri Tutmaktadır. 
            //System.Collection.generic
            Dictionary<int,string> kullanicilar = new Dictionary<int, string>();
            kullanicilar.Add(1,"Melih Ömer Kamar");
            kullanicilar.Add(2,"Zikriye Ürkmez");
            kullanicilar.Add(3,"Patika.Dev");
            kullanicilar.Add(4,"Kodluyoruz.Org");

            //Dizi Elemanlarına Erişim
            System.Console.WriteLine("*** Elemanlara Erişim ***");
            System.Console.WriteLine(kullanicilar[2]);
            foreach (var item in kullanicilar)
            {
                System.Console.WriteLine(item);
                System.Console.WriteLine(item.Value);
                System.Console.WriteLine(item.Key);
            }
            //Count
            System.Console.WriteLine("*** Count ***");
            System.Console.WriteLine(kullanicilar.Count);
            //Contains
            System.Console.WriteLine("*** Contains ***");
            System.Console.WriteLine(kullanicilar.ContainsKey(2));
            System.Console.WriteLine(kullanicilar.ContainsValue("Deniz Arda"));
            //Remove
            System.Console.WriteLine("*** Remove ***");
            kullanicilar.Remove(2);
            foreach (var item in kullanicilar)
            {
                System.Console.WriteLine(item);
            }
        }   
    }
}
