//Operatorler
/*//Aritmetik Operatorler
//a++ -> a= a+1
var a = 10;
var b = 3;

var c=2;

// var sonuc = a+b;
// var sonuc = a-b;
// var sonuc = a*b;
//float sonuc = (float)a/(float)b;
//var sonuc = (a+b)*c;
//var sonuc = a%b; //Mod islemi yapar.Kalani verir.
var sonuc = a++;
//var sonuc = ++a;

Console.WriteLine(sonuc);

//Console.WriteLine(a);*/

//Aritmetik Operator Uygulamalari
/*
//a=10,b=5;c=20 ise c-a farkinin b kati kactir?
// int a=10;
// int b=5;
// int c=20;
// int sonuc = (c-a)*b;
// Console.WriteLine(sonuc);

//int? a=50; int b=20; ise a+b degerini hesaplayiniz.(Eger null ise sonuc nedir?)
//int? a=50; 
// int? a=null; 
// int b=20;
// //var sonuc = a+b;
// var sonuc = (a ?? 0)+b; //a null olursa yerine sifir yazmasi saglanir.
// Console.WriteLine(sonuc);

//a=10,b=20 ise a=b--; atamasindan sonra a ve b degerleri ne olur?
// int a =10;
// int b=20;
// a=b--;
// Console.WriteLine(a);
// Console.WriteLine(b);

//Klavyeden girilen bir sayinin tek/cift kontrolunu yapiniz.
Console.Write("Sayi: ");
int sayi = int.Parse(Console.ReadLine() ?? "0"); //parse ile ConvertToInt ayni komutlardir.
var sonuc = sayi % 2;
Console.WriteLine(sonuc);*/

//Atama Operatorleri
/*var a = 5;
var b=10;

a+= b; //a = a+b;
a+=5; 
a-=b;
a*=b;
a/=b;
a%=b;
Console.WriteLine(a);

//Math
//float sonuc;
double sonuc;
sonuc = Math.Pow(2,3); //2^3 -> float'ta saklamadi.
sonuc = Math.Sqrt(25); //Karekok
sonuc = Math.Abs(-10); //Mutlak deger
sonuc = Math.Round(4.5); //Asagi yuvarlar.
sonuc = Math.Round(4.6); //Yukari yuvarlar.
sonuc = Math.Ceiling(4.4); //Her zaman yukari yuvarlar.
sonuc = Math.Floor(4.6); //Her zaman asagi yuvarlar.
sonuc = Math.Max(10,20); //Buyuk olani verir.
sonuc = Math.Min(10,20); //Kucuk olani verir.
Console.WriteLine(sonuc);*/

//Karsilastirma Operatorleri
/*int a = 5,b=5, c=10, d=3;
string username = "sadikturan";
string password = "1234";

var sonuc = (a==b); //true
sonuc = (c==d); //false
sonuc = (username == "sadikturan"); //true
sonuc = (password == "124536"); //false

sonuc = (a != b);
sonuc = (a>c);
sonuc = (a<c);
sonuc = (a>=b);

//ternary
//var sonuc2= (a>b) ? "a buyuk":"b buyuk";
var sonuc2= (a>b) ? "a buyuk":(a==b) ? "a b eşit":"b buyuk";
Console.WriteLine(sonuc2);
Console.WriteLine(sonuc);*/

// Karsilastirma Operator uygulamalari
/*
//Klavyeden girilen yas bilgisine gore oy kullanabilme inceleyiniz.
// Console.WriteLine("Yas: ");
// var yas = Convert.ToInt32(Console.ReadLine());
// //var sonuc = (yas>=18);
// var sonuc = (yas>=18) ? "oy kullanabilirsiniz":"oy kullanmakmicin yasiniz uygun degil";
// Console.WriteLine(sonuc);
//Console.WriteLine("Oy Kullanabilme Durumu: "+sonuc);

//Girilen bir sayinin isaretini kontrol ediniz.
// Console.WriteLine("Sayi: ");
// var sayi = Convert.ToInt32(Console.ReadLine());

// var sonuc = (sayi>0) ? "Sayiniz pozitif!":"Sayiniz negatif";
// Console.WriteLine(sonuc);

//Girilen bir sayinin tek/cift durumunu kontol ediniz.
Console.WriteLine("Sayi: ");
var sayi = Convert.ToInt32(Console.ReadLine());

var sonuc = (sayi%2==1) ? "Sayiniz tek!": "Sayiniz cift";
Console.WriteLine(sonuc);*/

//Mantiksal Operatorler
/*var a = true;
var b = true;
var c = true;
var d = true;

//1-ve/&&
var sonuc = (a && b);
sonuc = (a&&c);
sonuc = (c&&d);
Console.WriteLine(sonuc);

//2-veya/||
sonuc = (a || b);
sonuc = (c||b);
sonuc = (c||d);
Console.WriteLine(sonuc);

//3-Degil/!
sonuc = !c;
Console.WriteLine(sonuc);*/

//Mantiksal Operator Uygulamalari
/*//1.Yasi 18'den buyuk ya da veli izni varsa bir iste calisabilir durumunu kontrol ediniz.
// int yas = 22;
// bool veli_izin = true;

// bool yas_kontrol = (yas>=18);
// bool veli_kontrol = (veli_izin);

// var sonuc = (yas_kontrol || veli_kontrol) ? "calisabilir":"calisamaz";
// Console.WriteLine(sonuc);

//2.Ders notu 50-100 arasindaysa gecti degilse kalsin bilgisini yazdiriniz.
// int ders_notu=55;
// var sonuc = ((ders_notu>=50) && (ders_notu<=100)) ? "gecti":"kaldi";
// Console.WriteLine(sonuc);

//3.Ders ortalamasi en az 70 puan ve zayif yoksa tesekkur belgesi alabilme durumunu kontrol ediniz.
// int ders_ort = 65;
// int zayif = 0;
// // var sonuc = (ders_ort>=70 && zayif==0) ? "tesekkur alabilir":"tesekkur alamaz";
// var sonuc = (ders_ort>=70) ?
//             ((zayif==0) ? "Tesekkur alabilir":"Zayifinizin olamamasi gerekiyor."):
//             "Notunuz en az 70 olmalidir.";
// Console.WriteLine(sonuc);

//4.Ise girmek icin en az onlisans ya da lisasns mezunu olma durumunu kontrol ediniz. Sigara kullanmama kosulu.
// string egitim = "lisans";
// bool sigara_icme = true;
// //var sonuc = ((egitim=="lisans" || egitim=="lisans") && sigara_icme==false) ? "ise girebilir":"ise giremez";
// var sonuc = ((egitim=="lisans" || egitim=="lisans") && !sigara_icme) ? "ise girebilir":"ise giremez";
// Console.WriteLine(sonuc);

//5.Uygulamaya giris kontrolu- username ya da parola icin yapiniz.
string email = "sev@gmail.com";
string username = "sevde";
string parola = "1234";

var sonuc = ((email == "sev@gmail.com" || username=="sevde") && parola=="1234") ? "giris yapildi":"giris yapilamadi";
Console.WriteLine(sonuc);*/

//Random
var rnd = new Random(); //Nesne olusturulur,uzerinden metodlara erisilir.
int sayi = rnd.Next();  //Herhangi bir deger verilmezse negatif olmayan rastgele sayi uretir.
int sayi2 = rnd.Next(100); //100'e kadar rastgele sayi uretir. 
int sayi3 = rnd.Next(50,100); //50-100 arasinda
Console.WriteLine(sayi);

string[] takimlar = {"Besiktas","Galatasaray","Fenerbahce","Trabzonspor"};
int sayi4 = rnd.Next(3); 
int sayi5 = rnd.Next(0,4); 
Console.WriteLine(takimlar[sayi5]);
