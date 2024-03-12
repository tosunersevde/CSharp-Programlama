//For Dongusu
//kontrol degiskeni-kontrol(mekanizma)-guncellenmesi
// for(var i = 1;i <=100; i++){
//     Console.WriteLine(i);
// }

//For Dongusu Uygulamalari
//1-"1-100" arasindaki sayilarin toplamini hesaplayiniz.
// int toplam = 0;
// for(var i=1;i<100;i++)
// {
//     toplam+=i;
// }
// Console.WriteLine(toplam);

/*int toplam = 0;
for(var i=1;i<100;i++)
{
    if(i%2 == 0)
    {
        toplam+=i;
    }
}
Console.WriteLine(toplam);*/

//2-Klavyeden girilen baslangic ve bitis degerleri arasindaki tum sayilarin toplamini hesaplayiniz.
// Console.Write("Baslangic: ");
// var baslangic = Convert.ToInt32(Console.ReadLine());
// Console.Write("Bitis: ");
// var bitis = Convert.ToInt32(Console.ReadLine());

// Console.Write("Artis Miktari: ");
// var artis = Convert.ToInt32(Console.ReadLine());

// var toplam = 0;
// for(var i=baslangic; i < bitis; i = i+artis)
// {
//     toplam+=i;
// }
// Console.WriteLine(toplam);

//3- {"ali","ahmet","can","yelda","seda"} dizisindeki tum elemanlari ekrana yazdirin.
// string[] isimler= {"ali","ahmet","can","yelda","seda"};
// for(var i=0;i<isimler.Length;i++){
//     Console.WriteLine(isimler[i]);
// }

//4-{1,3,4,34,41,56,89} dizisindeki sayilarin hangileri 3'un katidir?
// int[] sayilar  = {1,3,4,34,41,56,89};
// for(var i=0;i<sayilar.Length;i++){
//     if(sayilar[i]%3==0)
//         Console.WriteLine(sayilar[i]);
// }

//While Dongusu
// for(var i=0;i<10;i++){
//     Console.WriteLine(i);
// }

// var i = 0;
// while(i<10) //true sonsuz dongu
// {
//     Console.WriteLine(i);
//     i++;
// }

// string[] isimler = {"ali","ahmet","can"};
// var i = 0;
// while(i<isimler.Length){
//     Console.WriteLine(isimler[i]);
//     i++;
// }

// var secim = "e";
// var sayac = 1;
// var toplam = 0;

// while(secim =="e"){
//     Console.Write($"{sayac}.sayi: ");
//     toplam+=Convert.ToInt32(Console.ReadLine());

//     Console.Write("Devam Etmek Istiyor Musunuz? (e/h): ");
//     secim = Console.ReadLine();

//     sayac++;
// }

// Console.WriteLine($"{sayac-1} adet sayinin toplami: {toplam}");

//Break - Continue
// string isim = "Sadik Turan";

// for(var i=0;i<isim.Length;i++){
//     if(isim[i] == 'i'){
//         //continue; //sonraki turlara devam eder.
//         //break; //Donguyu bitirir.
//     }
//     Console.WriteLine(isim[i]);
// }

// int x = 0;
// while(x<5) {
//     //x++ yazilirsa x'i once artirdigi icin sonsuz dongu olusmaz.
//     if(x==3){ 
//         //continue; //x uc olmaya devam eder ve besten kucuk oldugu icin sonsuz dongu olur.
//         break; //0,1,2 yazar ucu yazmaz.
//     }   
//     Console.WriteLine(x);
//     x++; 
// }

//While Dongusu Uygulamasi

//Sayi Tahmin
//1-100 arasinda rastgele tutulan bir sayiyi buldurmaya calissin.
//Tanimlanan hak bittiginde oyun bitmeli.
// using System.Data;

// var rnd =  new Random();
// int tutulan = rnd.Next(1,100);
// int hak = 3;

// while(hak>0){
// Console.WriteLine(tutulan);

//     Console.Write("Sayi: ");
//     int sayi = Convert.ToInt32(Console.ReadLine());

//     hak--;

//     if(sayi==tutulan){
//         Console.WriteLine("Tebirkler Bildiniz!");
//     }
//     else{
//         if(hak==0){
//             Console.WriteLine("Oyun Bitti!");
//             break;
//         }
//         if(tutulan >sayi){
//             Console.WriteLine("Yukari!");
//         }
//         else{
//             Console.WriteLine("Asagi!");
//         }
//     }
// }

// Do-While Dongusu
// int i = 1;

// do{
//     Console.WriteLine(i);
//     i++;
// }while(false); 
// //Donguye bir kez girer, sonrasi icin dongu sartlarinin gerceklesmesi gerekir.

// Console.Write("Adet: ");
// int adet = Convert.ToInt32(Console.ReadLine());

// string[] urunler = new string[adet];

// int i=0;

// do{
//     Console.Write("Urun Adi: ");
//     urunler[i] = Console.ReadLine() ?? ""; //Urun adi olmazsa bos deger atanir.

//     i++;
// }while(adet != i); //Dongu adet sayisina esit omyaincaya kadar devam eder.

// Console.WriteLine("Urunler Listeleniyor...");

// for(var a= 0;a<urunler.Length;a++)
// {
//     Console.WriteLine(urunler[a]);
// }

//Foreach Dongusu
string ad= "Sevde";

// for(var i=0;i<ad.Length;i++)
// {
//     Console.WriteLine(ad[i]);
// }

foreach(var harf in ad){
    Console.WriteLine(harf);
}

int[] sayilar = {10,20,40,45};

foreach(var sayi in sayilar)
{
    if(sayi == 20)
        continue; //Haricindekileri yazar.
        //break; //Oraya kadar yazar.
    Console.WriteLine(sayi);
}

