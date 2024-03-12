using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp_Collections
{
    class Program
    {
        static void Main(string[] args){
            //Array
            // int[] sayilar = new int[5]; //Array'lerde olusturulan bellek alani sabittir, degistirilemez.
            // sayilar[0] = 10; //Dizilerde sadece belli bir veri tipine bagli kalinir.

            // Soru[] sorular = new Soru[5];
            // sorular[0] = new Soru();

            //Collections - Dinamik Kapasite
            //non-generic collections / Tip tanimlamasina bagli olmadan kullanilir.
            //    ->ArrayList -> int,string // Aynı collection'da farkli veri tipleri kullanilabilir.
            //generic collections
            //    ->int,string -> Dizilerde oldugu gibi tip tanimlanmalidir.

            //ArrayList
            //non-generic -> Herhangi bir tipte obje saklanabilir.
            //Dinamik 

            // ArrayList liste = new ArrayList();

            // liste.Add(10);
            // liste.Add("10");
            // liste.Add("Ali");
            // liste.Add(null);
            // liste.Add(true);

            // var liste2 = new ArrayList() {
            //     5,
            //     "fatma",
            //     false,
            //     4.5,
            //     null
            // };

            // int[] sayilar = {10,20,30};
            // liste.AddRange(sayilar);

            // //var eleman = liste[0]; //obje turunde alir.
            // var eleman = (int)liste[0]; //Donusum saglar.
            // var isim = liste[2].ToString(); 

            // Console.WriteLine(eleman);
            // Console.WriteLine(isim);

            // //insert-ekleme
            // liste.Insert(1,"sevde"); //Tek eleman ekleme
            // liste.InsertRange(2,liste2); //Birden fazla eleman ekleme-collection ekleme

            // //remove
            // liste.Remove(null); //Veriyi liste uzerinden siler.
            // liste.RemoveAt(2); //İndeksteki veriyi listeden siler.
            // liste.RemoveRange(2,3); //2 numaralai indeksten itibaren silinecek eleman sayisi

            // //contains, indexOf
            // Console.WriteLine(liste.Contains(10)); //Listede icerik kontrolu
            // Console.WriteLine(liste.IndexOf(10)); //Listedeki konumunu verir.

            // foreach (var item in liste)
            // {
            //     Console.WriteLine(item);
            // }

            //Generic List
            // List<int> sayilar = new List<int>();

            // sayilar.Add(10);
            // sayilar.Add(20);

            // List<string> isimler = new List<string>() {"ali","ayse","fatma"}; //null da atanabilir.

            // List<Product> urunler = new List<Product>();
            // urunler.Add(new Product() {Id=1,Title="Iphone14",Price=40000});
            // urunler.Add(new Product() {Id=2,Title="Iphone15",Price=50000});
            // urunler.Add(new Product() {Id=3,Title="Iphone16",Price=60000});

            // urunler.Insert(urunler.Count, new Product() {Id=4,Title="Iphone17",Price=70000});
            // //Belirtilen indekse ekleme yapar, count ile index sayisi ile son elemana eklenmis olur.

            // urunler.RemoveAt(2); //2 numarali-indexteki urun
            // urunler.Remove(urunler[0]); //Silmek istenilen urunun adresi-referansi verilir.

            // foreach (var urun in urunler)
            // {
            //     Console.WriteLine(urun.Title+" "+urun.Price);
            // }

            //Dictionary - Generic sinifi icinde
            //Key-Value ->plaka-sehir
            Dictionary<int,string> plakalar = new Dictionary<int, string>();

            plakalar.Add(41,"Kocaeli");
            plakalar.Add(34,"Istanbul");
            plakalar.Add(53,"Rize");

            Dictionary<int,string> sayilar = new Dictionary<int, string>(){
                {1,"Bir"},
                {2,"Iki"},
                {3,"Uc"}
            };

            Console.WriteLine(plakalar[41]);
            if(plakalar.ContainsKey(34)) { //Varsa yazar, yoksa yazmaz.
                Console.WriteLine(plakalar[34]);
            }

            foreach (KeyValuePair<int, string> plaka in plakalar) //foreach (var plaka in plakalar)
            {
                Console.WriteLine(plaka.Key+" "+plaka.Value);
            }

            //Update 
            sayilar[1] = "one";
            //Delete
            //sayilar.Remove(1); //1 numarali key bilgisini siler.
            sayilar.Clear(); //Collection veri tipi icerisindeki butun elemanlar sifirlanir.

            Console.WriteLine(sayilar[1]);

        }
    }

    // class Product{
    //     public int Id { get; set; }
    //     public string ? Title { get; set; }
    //     public double Price { get; set; }

    // }
}
