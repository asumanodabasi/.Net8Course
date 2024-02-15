
using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();
            SelamVer("Ayşe");
            SelamVer();
            int sonuc = Topla(3,52);
            string[] öğrenciler = new string[3];
            öğrenciler[0] = "Ayşe";
            öğrenciler[1] = "Fatma";
            öğrenciler[2] = "Ali";
            for (int i = 0; i < öğrenciler.Length; i++)
            {
                Console.WriteLine(öğrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Sivas", "Antalya" };
            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);
            //string,interface,class,abstract..bunlar referans tipi olduğu için s2,s1'in referansını alır ve artık değeri s1'inkiyle aynı olur.Sonuc Adana olur

            int sayi1 = 1;
            int sayi2 = 11;
            sayi2 = sayi1;
            sayi1 = 30;
            Console.WriteLine(sayi2);
            //int,doube,bool,long..bunlar değer tipidir.Birbirine eşitleyip sayi1'i değiştirdiğinde sayi1'in değişmesi sayi2'yi etkılemez.Sonuc 1 olur.

            Person person1 = new Person();
            person1.FirstName = "Engin";
            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara1", "İstanbul1", "İzmir1" };
            yeniSehirler1.Add("Karaman");
            foreach (string sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);


        }

        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Merhaba"+isim);
        }

        static int Topla(int sayi1=5,int sayi2=10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("toplam: "+ sonuc);
            return sayi1+sayi2;
        }

        private static void Degiskenler()
        {
            string mesaj = "merhaba";
            double tutar = 100000;
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Asuman";
            string soyadı = "Odabasi";
            int dogumYili = 2003;
            long tcNo = 1345678910;
           

            Console.WriteLine(tutar * 1.18);
        }
    }
    
    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
