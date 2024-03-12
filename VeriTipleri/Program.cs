//Veri Tipleri
/*int sayi = 10; //var denildiginde de C#otomatik degisken veri tipini tanimlar.
float kdvOrani = 1.18f; //default olarak double oldugundan onun icin belirtilmesine gerek yoktur.
decimal oran = 1.18m;
char cinsiyet = 'k';
string cinsiyet2 = "Kadin";
string urunAdi = "Samsung S23";
var satisDurumu = false;*/

//Tip Donusumleri
/*//Console.WriteLine("1.sayi: "); //Alt satira gecerek yazdirir.
Console.Write("1.sayi: ");
//var sayi1 = Console.ReadLine();
var sayi1 = Convert.ToInt32(Console.ReadLine());
//string? sayi1 = Console.ReadLine();  //nullable
//Farkli veri tipinde olacak degiskene string atanmamasi icin uyari verir.
//Soru isareti eklenmesi ile uyari gider.

Console.Write("2.sayi: ");
var sayi2 = Convert.ToInt32(Console.ReadLine());

//var toplam = sayi1+sayi2; //String iki veriyi toplar, arka arkaya yazar, birlestirir.

var toplam = sayi1+sayi2;
Console.WriteLine(toplam);*/

//implicit-explicit casting:
/*//int a = 2222222;
//byte b = a; //byte degerini astigi icin hata verir.
int a = 10;
long b = a;

long d = 20;
int e = (int)d; //int'e donusturme olmasa hata verir.

double f = 20.5;
float g = (float)f; //vdri kaybi goz onune alarak yapilir.

double h = 10.5;
int i = (int)h;

Console.WriteLine(i);

int x = 10;
string z = x.ToString();*/

//Nullable Types
//int a = 10; //value type'larda degisken atamasi yapilmalidir.
//Referans type'lar nullable'dir.
//int maas =  null; //value type'lar belirsizlik icermez
//string isim = null; //Referans veri tipleri null degiskene izin verebilir.
//Sebebi ise bellkete saklanma alanlari farklidir; value:stack,referans:heap
//int maas = //db(veritabani)'den gelecek bilgi bilinmez
int? maas = null;
bool? isActive = null;
//int? maas = default; /7Sifir atar.
/*if(maas.HasValue){
    //maas var
}else{
    //maas yok
}*/
Console.WriteLine(maas.HasValue); //Bir degerin olup olmadigini soyler, atama yok.
Console.WriteLine(maas.GetValueOrDefault()); //int rurunde value type'in default'u olan sifir'i getirir.
//Herhangi bir atama yapilmadi ise reference type'lar null degeri alir.
Console.WriteLine(isActive.GetValueOrDefault());
