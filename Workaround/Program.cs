using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workaround
{
     class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            //Vatandas vatandas1 = new Vatandas();  //İnstance

            SelamVer(isim: "Engin");
            SelamVer(isim: "Ahmet");
            SelamVer(isim: "Ayşe");
            SelamVer(isim: "Noname");

            int sonuc = Topla(6, 58);

            //Diziler --> arrays

            //string ogrenci1 = "Engin";
            //string ogrenci2 = "Kerem";
            //string ogrenci3 = "Berkay";


            //Stack Heap Referans Tipler
            //null reference exception Sen bunu newlemedin Yer açman gerek.
            //Garbage Collector --> Çöp toplayıcı --> Bellekten atıyor
            //Array ,Class, Interface, Abstract --> Referans Tiplerdir stringler referans tiptir

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            //int sayi1 = 10;
            //int sayi2 = 20;
            //sayi2 = sayi1;
            //sayi1 = 30;
            //sayi2 = ??;
            //Değer tipler int, double, bool Bunlar Atama yapılır. Değiştiğinde sonuç etkilenmez. Sonuç = 10;

            Person person1 = new Person();
            person1.FirstName = "Engin";
            person1.LastName = "Demiroğ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "Murat";

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            //MyList  //Tip güvenli yapı
            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };  //generic koleksiyon
            yeniSehirler1.Add("Adana 1");
            foreach (var sehir  in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        static void SelamVer(string isim)   //Static olayını boşver // bu metot adı da selamver  
                                            //void metotlar sadece işi yapar herhangi bir bilgi vermez emir kipidir
        {
            Console.WriteLine("Merhaba" + " " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)  //sonuç veriyorsa
        {

            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + sonuc.ToString());
            return sayi1 + sayi2;
        }



        /*private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000;  //dbden gelir
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Engin";
            string soyad = "Demiroğ";
            int dogumYili = 1985;
            long tcNo = 12345678910;

            Console.WriteLine(tutar * 1.18);

            Console.WriteLine("Hello, World!");
        }


        //pascal casing
        public class Vatandas
        {
            public string Ad { get; set; }

            public string Soyad { get; set; }

            public int DogumYili { get; set; }

            public long TcNo { get; set; }

        }*/
    }
}
