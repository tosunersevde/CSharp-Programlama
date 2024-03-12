using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp_Collections
{
    class Program
    {
        //class uzerinden dogrudan cagrilabilir. Static olan metodlar her nesne icin kopyalanmaz.
        // static void parola_kontrol(string password){
        //     if(password.Length<6 || password.Length>=10){
        //         throw new Exception("Parola 6-10 karakter araliginda olmalidir!");
        //     }
        //     if(!password.Any(char.IsDigit)){ //Bir karakterin sayisal olup olmadigini kontrol eder.
        //         throw new Exception("Parola en az bir rakam icermelidir!");
        //     }
        //     if(!password.Any(char.IsLetter)){ //Bir karakterin harf olup olmadigini kontrol eder.
        //         throw new Exception("Parola en az bir harf icermelidir!");
        //     }
        // }
        
        static void Main(string[] args){
            //Exception - Hata - Exceptionsinifindan gelirler.
            //System.FormatException
            //System.DivideByZeroException
            //System.NullReferenceException

            // try{
            //     Console.Write("1.Sayi: "); //string giris yapilirsa
            //     int sayi1 = Convert.ToInt32(Console.ReadLine());

            //     Console.Write("2.Sayi: "); 
            //     int sayi2 = Convert.ToInt32(Console.ReadLine());
            //     //TryParse ozelligi ile gelen bilginin int'e cevrilebilir olup olmadigi kontrol edilebilir.

            //     var sonuc = sayi1 / sayi2; //sifir girilirse sifira bolme hatasi
            //     Console.WriteLine(sonuc);
            // }
            // catch(System.FormatException){
            //     Console.WriteLine("Sayisal bilgileri dogru giriniz!");
            // }catch(System.DivideByZeroException){
            //     Console.WriteLine("Ikinci sayi sifir olmamalidir!");
            // }
            // catch(Exception ex){ //Genel herhangi bir hata icin hata mesaji verir.
            //     Console.WriteLine("Bir hata olustu!");
            //     Console.WriteLine(ex.Message);
            // }
            
            //Urun urun; //new ile bellekte yer ayrilmamis nesne uzerinden islem yapilirsa
            // Urun urun = null; //Calisma zamaninda hata verir.
            // Console.WriteLine(urun.UrunAdi);

            //Exception Handling - Hatayi ele alaral hata gelebilecek kodlari daha gucenli hale alma

            //Hata Firlatma
            // int sayi=10;
            // if(sayi>5){
            //     throw new Exception("Sayi 5'den buyuk olamaz!"); //Istege bagli exception firlatma
            // }

            //Parola kontrol
            // Console.Write("Parola: ");
            // string parola = Console.ReadLine();

            // try{
            //     parola_kontrol(parola);
            //     Console.WriteLine("Parola Gecerli!");
            // }
            // catch(Exception e){
            //     Console.WriteLine(e.Message);
            // }

            //Debug
            var sayi1 = 10;
            var sayi2 = 20;

            var sonuc = Toplam(sayi1,sayi2);
            
            Console.WriteLine(sonuc);
        }

        static int Toplam(int a, int b){
            var toplam = a+b;
            return toplam;
            
        }
    }
    // class Urun
    // {
    //     public string UrunAdi { get; set; }
    // }
}

