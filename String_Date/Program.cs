
//String Karakter Dizileri
/*//char cinsiyet = 'E';
//string cinsiyet2 = 'Ekek';
//string cinsiyet2 = 'E';

Console.Write("Adi: ");
//string? ad = Console.ReadLine();
var ad = Console.ReadLine();

Console.Write("Soyadi: ");
//string? ad = Console.ReadLine();
var soyad = Console.ReadLine();

Console.Write("Yas: ");
//string? ad = Console.ReadLine();
var yas = Console.ReadLine();

//String reference ancak digerler referencler gibi mutable degil, immutable(degistirilemez)'dir.
//Uzerine bir deger atilmak istendiginde farkli bir bellek alaninda yeniden tanimlanir.

//string ad = "Sevde";
//string soyad = "Tosuner";
//string yas = "20";

//String Concat(Birlestirme)
//string mesaj  = ad +" "+ soyad +" isimli kisi "+yas+ " yasindadir.";

//String interpolation
string mesaj = $"{ad} {soyad} isimli kisi {yas} yasindadir.";

Console.WriteLine(mesaj);*/

//String Methods - String obje uzerinden ulasilir.
/*string mesaj = $"Sevde Tosuner, isimli kisi, 22 yasindadir.  ";

//int adet = mesaj.Length; //Mesaj degiskeninin kac karakter oldugunu soyler. 
//Console.WriteLine(adet);
//var sonuc = mesaj.ToLower(); //Butun string ifadeyi kucuk karakterlere cevirir.
//var sonuc = mesaj.ToUpper(); //Butun karakterleri buyuk harf yapar.
// var sonuc = mesaj.Trim(); //Bastaki- sondaki bosluk karakterleri silinir.
// var sonuc = mesaj.Split(" "); //String ifadeyi bosluk karakteri ile ayriri, sonuc bir dizidir.
//var sonuc = mesaj.Split(" ")[2]; 
//var sonuc = mesaj.Split(",")[0];
//var sonuc = mesaj.StartsWith("Sevde"); //Bilgi 'Sevde' ile mi basliyor- overload metod
//var sonuc = mesaj.EndsWith(".."); //Bilgi '..' ile mi bitiyor
//var sonuc = mesaj.Contains("Sevde"); //String icinde var mi?
//var sonuc = mesaj.IndexOf("Sevde"); //Yoksa -1 indeksi verir, varsa baslangic indeksini verir.
//var sonuc = mesaj.Substring(10); //Baslangic indexten sonuna kadar olani ya da verilen uzunluk kadar getirir
var sonuc = mesaj.Substring(6,5);
// var sonuc = mesaj[3];

//Console.WriteLine(mesaj);
Console.WriteLine(sonuc);*/

//String Uygulamalari
/*using System.Data;

string kursAdi = ".NET 7 ile C# Programlama Dili";
//1.Kac karaktere sahiptir?
//2.Hepsini kucuk harf yapin.
//3.'.' ile mi baslamaktadir?
//4.'C#' bilgisi hangi konumda?
//5.'C#' bilgisini iceriyor mu?
//6.'Dili' kelimesi yerine 'Dersleri' yaziniz.

var karakterSayisi = kursAdi.Length;
Console.WriteLine("Karakter Saysisi: "+karakterSayisi);//30

var kucukKursAd = kursAdi.ToLower();
Console.WriteLine("Kucuk Harfle Kurs Adi: "+kucukKursAd);

var nokta = kursAdi.StartsWith(".");
Console.WriteLine("String . ile basliyor: "+nokta);//30

var konum = kursAdi.IndexOf("C#");
Console.WriteLine("Konum: "+konum);

var iceriyorMu = kursAdi.Contains("C#");
Console.WriteLine("C# İcerir mi: "+iceriyorMu);

var guncelString = kursAdi.Replace("Dili","Dersleri");
Console.WriteLine("Guncel String: "+guncelString);*/

//DateTime
//DateTime simdi = DateTime.Now; //DateTime tipinde bir obje dondurur.
var simdi = DateTime.Now; 
Console.WriteLine(simdi); //Su anki tarih ve saat bilgilerini yazdirir.
Console.WriteLine(simdi.Year); //Su anki yil bilgilerini yazdirir.
Console.WriteLine(simdi.Month); //Su anki ay bilgisini yazdirir.
Console.WriteLine(simdi.Day); //Su anki gün bilgisini yazdirir.
Console.WriteLine(simdi.DayOfWeek); //Haftanin gunu
Console.WriteLine(simdi.Hour); //Saat
Console.WriteLine(simdi.Minute); //Dakika
Console.WriteLine(simdi.Second); //Saniye

DateTime dt = new DateTime(2018,6,10,14,30,45); //DateTime icin new ile yeni bir obje olusturarak tarih olusturulabilir.
DateTime dt2 = dt.AddYears(1); //yeni bir obje olusturur.
DateTime dt3 = dt.AddHours(2);

Console.WriteLine(dt2.Year);
Console.WriteLine(dt3.Hour);

var fark = simdi - dt;
Console.WriteLine(fark.TotalDays); //Olusturulan iki tarih objesi uzerinden toplam gun farkini verir.

Console.WriteLine(fark.TotalHours); 
Console.WriteLine(fark.TotalMinutes); 