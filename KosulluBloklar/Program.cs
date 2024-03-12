//if-else blogu
// if (true) //Direk calisir, blok icini yazdirir. False olsa calistirmaz. //5>3
//     Console.WriteLine("Merhaba BTK Akademi");

// var isLogin =true;

// if(isLogin) //isLogin == true
//     Console.WriteLine("Merhaba BTK Akademi");

// string username = "sadikturan";
// string password = "12345";

//var isLogin = (username=="sadikturan" && password=="12345");

// if (username=="sadikturan" && password=="12345") //(isLogin) //isLogin == true
//     Console.WriteLine("Merhaba BTK Akademi");
// else{
//     Console.WriteLine("Giris Basarisiz"); //Tek satirsa parantezsiz kullanilabilir.
// }

// if (username=="sadikturan"){
//     if (password=="12345"){
//         Console.WriteLine("Merhaba BTK Akademi");
//     }else{
//         Console.WriteLine("Parola Yanlis");
//     }
// }  
// else{
//     Console.WriteLine("Username Yanlis");
// }

//elseif blogu
// if (username!="sadikturan"){
//     Console.WriteLine("Username Yanlis");
// }
// else if (password!="12345"){
//     Console.WriteLine("Parola Yanlis");
// }
// else{
//     Console.WriteLine("Merhaba BTK Akademi");
// }

// int x = 10;
// int y=20;

// if(x>y){
//     Console.WriteLine("x y'den buyuk");
// }
// else if(x==y){
//     Console.WriteLine("x y'ye esit");
// }
// else{
//     Console.WriteLine("x y'den kucuk");
// }

//if-else uygulamalari
//1-Kullaniciya sunulan bir menu icinden secilecek olan 4 islem tipine gore hesaplama yapiniz.
// Console.Write("1.Sayi: ");
// var sayi1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("2.Sayi: ");
// var sayi2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Toplama icin: +");
// Console.WriteLine("Cikartma icin: -");
// Console.WriteLine("Carpma icin: *");
// Console.WriteLine("Bolme icin: /");
// Console.Write("Seciminiz: ");
// var secim = Console.ReadLine();

// double sonuc = 0;
// bool ok = true;

// if(secim=="+")
// {
//     sonuc = sayi1+sayi2;
// }
// else if(secim=="-")
// {
//     sonuc = sayi1-sayi2;
// }
// else if(secim=="*")
// {
//     sonuc = sayi1*sayi2;
// }
// else if(secim=="/")
// {
//     if(sayi2 == 0)
//     {
//         ok = false;
//     }
//     sonuc = sayi1/sayi2;
// }
// else
// {
//     ok = false;
//     Console.WriteLine("Yanlis Secim Yaptiniz!");
// }
// if(ok){
//     Console.WriteLine($"Islem Sonucu: {sayi1} {secim} {sayi2} = {sonuc}");
// }

//2-Bir ogrencinin 2 yazili 1 sozlu notunu alip hesaplanan ortalamaya gore not araligina kasilik gelen not bilgisini yazin
//0-24 -> 0
//25-44 -> 1
//45-54 -> 2
//55-69 -> 3
//70-84 -> 4
//85-100 -> 5
// Console.Write("1.Yazili: ");
// int not1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("2.Yazili: ");
// var not2 =Convert.ToInt32(Console.ReadLine());

// Console.Write("Sozlu: ");
// var sozlu = Convert.ToInt32(Console.ReadLine());

// var ortalama = (not1 + not2 + sozlu)/3;
// int not = -1;
// bool ok = true;

// if(ortalama >=0 && ortalama < 25){
//     not = 0;
// }
// else if(ortalama >=25 && ortalama < 45){
//     not = 1;
// }
// else if(ortalama >=45 && ortalama < 55){
//     not = 2;
// }
// else if(ortalama >=55 && ortalama < 70){
//     not = 3;
// }
// if(ortalama >=70 && ortalama < 85){
//     not = 4;
// }
// else if(ortalama >=85 && ortalama <= 100){
//     not = 5;
// }
// else{
//     Console.WriteLine("Yanlis not girdiniz: ");
// }

// if(ok){
//     Console.WriteLine($"Not Ortalamaniz : {ortalama} Notunuz: {not}");
// }


//3- Girilen 2 sayidan en buyugunu bulun.
/*Console.Write("a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("c: ");
int c = Convert.ToInt32(Console.ReadLine());

int enbuyuk = 0;

if(a>b && a>c){
    enbuyuk = a;
}else if(b>a && b>c){
    enbuyuk = b;
}else{
    enbuyuk=c;
}

Console.WriteLine("En Buyuk: "+enbuyuk);*/

//Switch
//int gun = 1; //0-pazar,1-pazartesi,...,6-cumartesi
// int gun = (int)DateTime.Now.DayOfWeek;

// switch(gun){
//     case 0:
//         Console.WriteLine("Pazar");
//         break;
//     case 1:
//         Console.WriteLine("Pazartesi");
//         break;
//     case 2:
//         Console.WriteLine("Sali");
//         break;
//     case 3:
//         Console.WriteLine("Carsamba");
//         break;
//     case 4:
//         Console.WriteLine("Persembe");
//         break;
//     case 5:
//         Console.WriteLine("Cuma");
//         break;
//     case 6:
//         Console.WriteLine("Cumartesi");
//         break;

//     default:
//         Console.WriteLine("Hatali Gun!!!");
//         break;
// }

// 

//Ternary
int sayi = 10;

// var sonuc = (sayi % 2 == 0) ? 
//             "sayi cift": 
//             "sayi tek";

var sonuc = (sayi % 2 == 0) ? 
            (sayi>0) ? "sayi pozitif cift":"sayi negatif cift":
            (sayi>0) ? "sayi pozitif tek": "sayi pozitif tek";

Console.WriteLine(sonuc);

