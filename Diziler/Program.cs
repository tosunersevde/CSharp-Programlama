//Diziler
/*//string kursAdi = ".NET 7 ile C# Programlama Dili";
var kursAdi = ".NET 7 ile C# Programlama Dili".Split(' ');

//string[] isimler = new string[5]; //Icerisi bos olan bes alan

// isimler[0] = "Sevde";
// isimler[1] = "Nur";
// isimler[2] = "Halime";
// isimler[3] = "Selma";
// isimler[4] = "Hafsa";

string[] isimler = {"Sevde","Nur"};


Console.WriteLine(isimler[0]);

//int[] numaralar = new int[5];

int[] numaralar = {100,200,110};

// numaralar[0] = 100;
// numaralar[1] = 200;
// numaralar[2] = 300;
// numaralar[3] = 400;
// numaralar[4] = 500;

Console.WriteLine($"{numaralar[0]} numarali ogrencinin adi: {isimler[0]}");

//Console.WriteLine(kursAdi[0]);
//Console.WriteLine(kursAdi[5]);*/

//Dizi Metodlari (Array Methods)
/*string[] sehirler = {"Istanbul","Nigde","Giresun"};
int[] plakalar = {34,51,28};

//sehirler[0] = "Kirikkale";
sehirler.SetValue("Kirikkale",0); //Sifirinci indekteki sehri sakarya olarak degisitirir.

//Console.WriteLine(sehirler[0]);
Console.WriteLine(sehirler.GetValue(0)); //Sifirinci indeksteki degeri getirir.
Console.WriteLine(sehirler.Length); //Dizi uzunluk
Console.WriteLine(Array.IndexOf(sehirler,"Nigde")); //IndexOf metodu Arrya sinifi uzerinden cagrilmalidir.
//IndexOf ile bulunamadigi zaman -1 degerini verir.

Array.Sort(sehirler); //Dizi elelmanlarini siralar.

Console.WriteLine(sehirler.GetValue(0));
Console.WriteLine(plakalar.GetValue(0));

Array.Reverse(plakalar); //Dizi elemanlarini ters cevirir.

Console.WriteLine(plakalar.GetValue(0));

Array.Clear(sehirler); //Dizi icerigini tezmizler.

Console.WriteLine(sehirler.GetValue(0));
Console.WriteLine(sehirler.GetValue(1));
Console.WriteLine(sehirler.GetValue(2)); //Dizi bos oldugundan bos doner.

//Array.Clear(plakalar); //Dizi icerigini tezmizler.
Array.Clear(plakalar,0,1); //0.indekten itibaren bir tane temizler.

Console.WriteLine(plakalar.GetValue(0));
Console.WriteLine(plakalar.GetValue(1));
Console.WriteLine(plakalar.GetValue(2)); //Int Dizi bos oldugundan sifir(default) doner.*/

//Array Slicing - Dizi Parcalama
/*using System.ComponentModel;

string[] sehirler = {"Istanbul","Nigde","Giresun","Kirikkale","Elazig"};

//var sonuc = sehirler[0..3]; //0.indeksten 3.indekse kadar olan elelmanlari alir.

//Console.WriteLine(sonuc.Length);

// foreach(var sehir in sehirler) {
//     Console.WriteLine(sehir);
// }

foreach(var i in sehirler[0..3]){ //Bastan ucuncu indekse kadar
    Console.WriteLine(i);
}

foreach(var i in sehirler[..3]){ //Bastan ucuncu indekse kadar 
    Console.WriteLine(i);
}

foreach(var i in sehirler[..]){ //Hepsini yazdirir.
    Console.WriteLine(i);
}

foreach(var i in sehirler[2..]){ //Ikinci indeksten sona kadar yazdirir.
    Console.WriteLine(i);
}

//Console.WriteLine(sonuc[0]);
//Console.WriteLine(sonuc[1]);
//Console.WriteLine(sonuc[2]);

string il = "Ankara";
Console.WriteLine(il[0]);
Console.WriteLine(il[..5]); //Ilk dort karakteri alir.*/

//Dizi Uygulama 
/*//Ogrenci-Notlar dizisi -> elemanlar kullanicidan alinan degerlerle doldurulacak.
var ogrenciler = new string[3];
var notlar = new int[3];

Console.Write("1.Ogrenci adi: ");
ogrenciler[0] = Console.ReadLine() ?? ""; //Bos gelirse null deger atilir, uyari gider.

Console.Write("1.Ogrenci notu: ");
notlar[0] = Convert.ToInt32(Console.ReadLine()); //Int'e cevirir.

Console.Write("2.Ogrenci adi: ");
ogrenciler[1] = Console.ReadLine() ?? "";

Console.Write("2.Ogrenci notu: ");
notlar[1] = Convert.ToInt32(Console.ReadLine());

Console.Write("3.Ogrenci adi: ");
ogrenciler[2] = Console.ReadLine() ?? "";

Console.Write("3.Ogrenci notu: ");
notlar[2] = Convert.ToInt32(Console.ReadLine());

foreach(var ogrenci in ogrenciler)
{
    Console.WriteLine(ogrenci);
}

foreach(var not in notlar)
{
    Console.WriteLine(not);
}

//Ogrenci dizisi kac elemanli?
Console.WriteLine("Ogrenciler dizisinin eleman sayisi: "+ogrenciler.Length);

//Ilk iki ogrencinin ad ve not bilgisi?
foreach(var i in ogrenciler[..2])
{
    Console.WriteLine(i);
} 
foreach(var i in notlar[..2])
{
    Console.WriteLine(i);
} 
//Tum ogrencilerin not ortalamasi?
var toplam = 0;
foreach(var i in notlar){
    toplam += i;
};
var ortalama = toplam / notlar.Length;
Console.WriteLine("Ogrencilerin not ortalamasi: "+ortalama);*/

//Cok Boyutlu Diziler
/*//Ali->50,60,70
//Veli->60,80,90
//Fatma->50,70,30
//Her ogrencinin not ortalamasini hesaplayiniz.

string[] ogrenciler = {"Ali","Veli","Fatma"};
int[,] notlar = new int[3,3];

notlar[0,0] = 50;
notlar[0,1] = 60;
notlar[0,2] = 70;

notlar[1,0] = 60;
notlar[1,1] = 80;
notlar[1,2] = 90;

notlar[2,0] = 50;
notlar[2,1] = 70;
notlar[2,2] = 30;

var ort1 = (notlar[0,0] + notlar[0,1] + notlar[0,2]) / 3;
var ort2 = (notlar[1,0] + notlar[1,1] + notlar[1,2]) / 3;
var ort3 = (notlar[2,0] + notlar[2,1] + notlar[2,2]) / 3;

Console.WriteLine($"{ogrenciler[0]} isimli ogrencinin not ortalamasi: {ort1}");
Console.WriteLine($"{ogrenciler[0]} isimli ogrencinin not ortalamasi: {ort2}");
Console.WriteLine($"{ogrenciler[0]} isimli ogrencinin not ortalamasi: {ort3}");*/

//Referans Tipler
//Bellegin heap alanindadirlar, stack alaninda adresleri tutulur.
//Kopyalama islemi yapildginda verileri kopyalamaz,stack'te ayni adresi gosteren iki farkli degisken olusur.
//Yapilan guncellemeler ayni adres uzerinde olacagi icin degisiklik her ikisinde de olur.
//class-array-string -> string farkli olarak farkli adres olusturur.
int x = 10;
int y = x;

Console.WriteLine(x); //10
Console.WriteLine(y); //10

x = 20;

Console.WriteLine(x); //10
Console.WriteLine(y); //20 - y etkilenmez.

int[] a = {10,20};
int[] b = a;

Console.WriteLine(a[0]); //10
Console.WriteLine(b[0]); //10

a[0] = 20;

Console.WriteLine(a[0]); //20
Console.WriteLine(b[0]); //20 - b etkilenir.