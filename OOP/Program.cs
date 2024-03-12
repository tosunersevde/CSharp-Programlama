//Program Class
using System;
using System.ComponentModel;
using System.IO;

// namespace ConsoleApp_OOP{ //Proje Adi
//     class Program{ //Class adi
//         static void Main(string[] args){ //Geri donus degeri olmayan static metod - parametresi string dizisi/parametre args
//             //Console.WriteLine("Merhaba BTK");

//             //class -> object(ogr1,ogr2)
//             // Ogrenci ogr1 = new Ogrenci(); //yeni nesne
//             // ogr1.OgrenciNo = "100";
//             // ogr1.AdSoyad = "Ada Bilgi";
//             // ogr1.Sube = "6/A";

//             // Ogrenci ogr2 = new Ogrenci();
//             // ogr2.OgrenciNo = "200";
//             // ogr2.AdSoyad = "Yigit Bilgi";
//             // ogr2.Sube = "7/A";

//             // Ogrenci ogr3 = new Ogrenci(); //yeni nesne
//             // ogr3.OgrenciNo = "300";
//             // ogr3.AdSoyad = "Cinar Turan";
//             // ogr3.Sube = "1/A";

//             Ogrenci ogr1 = new Ogrenci(){OgrenciNo = "100",AdSoyad = "Ada Bilgi",Sube = "6/A"};
//             Ogrenci ogr2 = new Ogrenci(){OgrenciNo = "200",AdSoyad = "Yigit Bilgi",Sube = "7/A"};
//             Ogrenci ogr3 = new Ogrenci(){OgrenciNo = "300",AdSoyad = "Cinar Turan",Sube = "1/A"};
//             Ogrenci ogr4 = new Ogrenci(){OgrenciNo = "400",AdSoyad = "Ahmet Turan",Sube = "1/A"};

//             // Ogrenci[] ogrenciler = new Ogrenci[3];

//             // ogrenciler[0] = ogr1;
//             // ogrenciler[1] = ogr2;
//             // ogrenciler[2] = ogr3;

//             Ogrenci[] ogrenciler = new Ogrenci[4] {ogr1,ogr2,ogr3,ogr4};

//             // ogr1.BilgileriYazdir(); //ogr1 metoddaki this yerine gecer.
//             // ogr2.BilgileriYazdir(); 
//             // ogr3.BilgileriYazdir(); 

//             // foreach(var ogr in ogrenciler){
//             //     //Console.WriteLine($"{ogr.OgrenciNo} numarali ogrencinin adi {ogr.AdSoyad} ve subesi {ogr.Sube}");
//             //     ogr.BilgileriYazdir();
//             //     ogr.BilgileriYazdir();
//             // }

//             foreach(var ogr in ogrenciler){
//                 // string sonuc = ogr.BilgileriYazdir();
//                 // Console.WriteLine(sonuc); //Geriye donus degeri olan method icin 
//                 Console.WriteLine(ogr.BilgileriYazdir());
//             }

//             // Console.WriteLine($"{ogr1.OgrenciNo} numarali ogrencinin adi {ogr1.AdSoyad} ve subesi {ogr1.Sube}");
//             // Console.WriteLine($"{ogr2.OgrenciNo} numarali ogrencinin adi {ogr2.AdSoyad} ve subesi {ogr2.Sube}");
//             // Console.WriteLine($"{ogr3.OgrenciNo} numarali ogrencinin adi {ogr3.AdSoyad} ve subesi {ogr3.Sube}");
//         }
//     }


//     class Ogrenci{
//         //property -> string,int
//         public string OgrenciNo { get; set; } //prop yazilirsa otomatik tamamlar.
//         public string AdSoyad { get; set; } //get set veri atarken veya alirken kontrol 
//         public string Sube { get; set; }
//         //<Nullable>enable</Nullable> disable yapilirsa kullanilmayabilir, uyari gider.

//         // string ogrenciNo;
//         // string adSoyad;
//         // string sube;

//         //methods -> bilgileri_yazdir()
//         // public void BilgileriYazdir() //Geri donus degeri olmayan
//         // {
//         //     Console.WriteLine($"{this.OgrenciNo} numarali ogrencinin adi {this.AdSoyad} ve subesi {this.Sube}");
//         //     //this bu siniftan turetilen nesneler uzerinden bilgileri yazdirir.
//         // }
//         //Console sinifi bir platforma bagli oldugu icin web uygulamalarinda kullanilamaz.

//         public string BilgileriYazdir() //Geri donus degeri olan
//         {
//             // string sonuc = $"{this.OgrenciNo} numarali ogrencinin adi {this.AdSoyad} ve subesi {this.Sube}";
//             // return sonuc;
//             return $"{this.OgrenciNo} numarali ogrencinin adi {this.AdSoyad} ve subesi {this.Sube}";
//         }
//         //Dogrudan platforma bagli bir sinif icermedigi icin web uygulamalarinda,console projesinde kullanilabilir,label'a vs. yazdirilabilir.
//     }
// }       

//.Net6 ve oncesinde System namespace'i altinda console sinifina erismek gerekirken sonrasinda otomatik erisislir.
//En basa Using System yazarak onun altindaki Console sinifina erisim saglandigi belirtiliyordu.
//<ImplicitUsings>enable</ImplicitUsings> otomatik gelir, disabled olursa using ile kullanim gerekir.

//ConsoleApp -> Program - Ogrenci
//System-> Console
//System.IO->File,Directory,Path

//Farkli bir namespace alanina ait sinif eklenmek istenirse using System.IO gibi yukarida eklenmelidir.
//Main metdo ilk cagrilan, proje baslangic yeridir.

// //Methods- Uygulama:Quiz Uygulamasi
// namespace ConsoleApp_OOP{ 
//     class Program{
//         static void Main(string[] args){
//             // var soru1 = new Soru() {
//             //     SoruMetni = "Hangisi programlama dili degildir?",
//             //     Secenekler = new string[4] {"Python","C#","Java","HTML"},
//             //     Cevap = "HTML"
//             // };

//             // var soru2 = new Soru() {
//             //     SoruMetni = "Hangisi en populer programlama dilidir?",
//             //     Secenekler = new string[4] {"Python","C#","Java","HTML"},
//             //     Cevap = "C#"
//             // };

//             // var soru3 = new Soru() {
//             //     SoruMetni = "Hangisi en populer web programlama platformu degildir?",
//             //     Secenekler = new string[4] {"Django","Asp.Net","Spring","Python"},
//             //     Cevap = "Python"
//             // };

//             var soru1 = new Soru(1,"Hangisi programlama dili degildir?",new string[4] {"Python","C#","Java","HTML"}, "HTML");
//             var soru2 = new Soru(2,"Hangisi en populer programlama dilidir?",new string[4] {"Python","C#","Java","HTML"}, "C#");
//             var soru3 = new Soru(3,"Hangisi en populer web programlama platformu degildir?",new string[4] {"Django","Asp.Net","Spring","Python"}, "Python");
//             //Contructor nesne tanimlandigi anda parametrelerin doldurulmasina olanak tanir.

//             var soru4 = new Soru(); //Herhangi bir parametre almayan contructor1'e baglidir.

//             //var soru4 = new Soru();
//             // var soru4 = new Soru(10);
//             // Console.WriteLine(soru4.SoruId);

//             // var sorular = new Soru[] {soru1,soru2,soru3};

//             // foreach(var soru in sorular)
//             // {
//             //     Console.WriteLine(soru.SoruMetni);
//             //     foreach(var secenek in soru.Secenekler)
//             //     {
//             //         Console.WriteLine(secenek);
//             //     }

//             //     //Kullanicidan cevap alma
//             //     Console.Write("Cevabiniz: ");
//             //     var cevap = Console.ReadLine();

//             //     if(soru.cevapKontrol(cevap)){
//             //         Console.WriteLine("Dogru Cevap!");
//             //     }else{
//             //         Console.WriteLine("Yanlis Cevap!");
//             //     }
//             // }   

//             //Access Modifiers-Erisim Belirtecleri / protected, internal, protected internal, private protected
//             //public olarak tanimlanmis olan ozellikler sinif disindan erisilebilir durumdadir.
//             //Class icerisinde ozellikler kullanilabilir ancak nesne uzerinden erisilemez.
            
//             Console.WriteLine(soru1.SoruYazdir());
//             Console.WriteLine(soru1.cevapKontrol("html")); //cevap kontrole erisilebilir, true-false deger dondurur.
        
//             Console.WriteLine(soru2.SoruYazdir());
//             Console.WriteLine(soru2.cevapKontrol("html")); 

//             Console.WriteLine(soru3.SoruYazdir());
//             Console.WriteLine(soru3.cevapKontrol("python")); 
//         }
//     }

//     class Soru{
//         //Parametre almayan constructor
//         public Soru() //Constructor method - sinif ismi ile ayni- calistirilmasi otomatik olur.
//         {
//             Console.WriteLine("constructor1");
//             //Console.WriteLine("Soru nesnesi olusturuldu."); //Her olusturulan nesne icin yazar.
//             this.SoruId = (new Random()).Next(11111,99999); //sayi araliginda soru id olusturur.
//         }
//         //Her bir nesne olusturuldugunda contructor-yapici metod olusturulur.

//         //Parametre alan constructor - tek parametre
//         public Soru(int soruId){
//             Console.WriteLine("constructor2");
//             this.SoruId = soruId;
//         }

//         public Soru(int soruId,string soruMetni, string[] secenekler,string cevap)
//         {
//             //Console.WriteLine("constructor3");
//             this.SoruId = soruId; //SoruId disardan gonderilen soruId'ye esit olur.
//             this.SoruMetni = soruMetni;
//             this.Secenekler = secenekler;
//             this.Cevap = cevap;
//         }

//         //properties
//         private int SoruId { get; set; } 
//         private string SoruMetni { get; set; }
//         private string[] Secenekler { get; set; }
//         private string Cevap { get; set; }

//         public string SoruYazdir()
//         {
//             string soru = "";
//             soru+=this.SoruMetni + '\n';
//             foreach(var secenek in this.Secenekler){
//                 soru+= secenek + "\n";
//             }
//             return soru;
//         }

//         //methods
//         public bool cevapKontrol(string cevap){ //Method parametresi bilinmiyor
//             return this.Cevap.ToLower() == cevap.ToLower(); //Hepsini kucuk harf yapsin, hata olmasin.
//         }
//     }
// }

//Static Methods
namespace ConsoleApp_OOP{ 
    class Program{
        static void Main(string[] args){
            // Random rnd = new Random(); //Random instance class-nesne olusturulmalidir.
            // Console.WriteLine(rnd.Next(1,100));

            // Math.Min(10,30); //Static class'tir, nesne olusturmadan dogrudan metodlara erisilebilir.

            //Soru(class) -> ornekler:soru1,soru2,soru3(nesneler)-> metodlar:soru1.soruYazdir()/Her nesne icin calismali
            //Intance metodlar her bir nesneye ozel olarak o nesnenin ozelliklerini kullanir.

            //Yardimci metod tanimlama durumlarinda nesne olusturulmasina gerek yoktur.

            var sonuc = HelperMethods.KarakterDuzelt("ölçme ve değerlendirme");
            Console.WriteLine(sonuc);
        
        }
    }

    class HelperMethods{
                public static string KarakterDuzelt(string str){
                    return
                        str.Replace("ö","o")
                        .Replace("ü","u")
                        .Replace("ı","i")
                        .Replace("ç","c")
                        .Replace("ğ","g")
                        .Replace("ş","s")
                        .Replace(" ","-");
                }
    }
    //Nesneye ozel degil, dogrudan sinif uzerinden cagrilan ve sinifa hizmet eden metod yazmak istenirse static method kullanilir.

    
}