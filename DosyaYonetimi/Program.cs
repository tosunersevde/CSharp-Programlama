//Dosya Okuma
//File sinifi static bir sinif oldugu icin dogrudan metodlarina erisebilir, yeni bir nesne olusturulmasi gerekmez.
// StreamReader sr = File.OpenText("deneme.txt");
// var s = "";

// //Console.WriteLine(sr.ReadLine());

// while((s=sr.ReadLine()) != null){ //Dosya icerigi bos olana kadar 
//     Console.WriteLine(s);
// }

//string sonuc = File.ReadAllText("deneme.txt"); //tum dosya icerigini yazar.
//Console.WriteLine(sonuc);

// string[] sonuc = File.ReadAllLines("deneme.txt"); //tum dosya icerigini yazar.
// Console.WriteLine(sonuc[0]); //Satir satir alir.

//Dosya Yazma ve Ekleme
//Dosyasi ilgili dizinde varsa dosya uzerine yazar, icerikler kaybolur, ekleme moduna cevrilebilir.

// using(StreamWriter sw = File.CreateText("deneme.txt")){; //using kapsaminda olusan nesne isi bittginde kapatilir.
// sw.WriteLine("Merhaba");
// sw.WriteLine("BTK");
// sw.WriteLine("Akademi");
// };

// using(StreamWriter sw = File.AppendText("deneme.txt")){; //Uzerine ekler, icerigi silmez.
// sw.WriteLine("Selam");
// sw.WriteLine("BTK");
// sw.WriteLine("Akademi");
// };

//sw.Close(); //Dosya kapatir, aksisi durdurur.

// 

//Klasorlerle Calisma
// Directory.CreateDirectory("temp");
// Directory.CreateDirectory("temp/deneme");
// Directory.CreateDirectory("temp/deneme2");

// if(Directory.Exists("temp/deneme2")){ //Klasor var mi kontrolu
//     Directory.Delete("temp/deneme2");
// }else{
//     Console.WriteLine("Silmek istediginiz klasor yok!");
// }

//Directory.Move(); Bulunulan konumdan baska konuma tasima
//string path = @"C:\Users\tosun\C#_Projects\Deneme";
// string path = Directory.GetCurrentDirectory() + "/temp"; //Bulunulan konuma-projedizinine ekler.
// Directory.CreateDirectory(path);

//Dosya ve Klasorlerle Calisma
string rootPath = Directory.GetCurrentDirectory();
// string[] dirs = Directory.GetDirectories(rootPath,"*",SearchOption.TopDirectoryOnly); //Butun ust klasorler

// foreach(var dir in dirs){ //Ust klasorlere ulasilir.
//     Console.WriteLine(dir);
// }


// string[] files = Directory.GetFiles(rootPath,"*",SearchOption.AllDirectories);

// foreach(var file in files){ //ALt klasorlere ulasilir.
//     Console.WriteLine(files);
// }

// string[] files = Directory.GetFiles(rootPath,"*.txt",SearchOption.AllDirectories);

// foreach(var file in files){
//     Console.WriteLine(file);
//     Console.WriteLine(Path.GetExtension(file)); //Dosya uzantisi verir.
//     Console.WriteLine(Path.GetFileNameWithoutExtension(file)); //Uzantisiz file name
//     Console.WriteLine(Path.GetFileName(file)); //Dosya ismini oldugu gibi verir.

//     var info = new FileInfo(file); //Intance sinif oldugundan ornek uretilmelidir.

//     Console.WriteLine($"{Path.GetFileName(file)}: {info.Length}");
// }   

//string path = "C:/Users/tosun/C#_Projects/ConsoleApp_DosyaYonetimi/img";
string source_path = "C:/Users/tosun/C#_Projects/ConsoleApp_DosyaYonetimi/img";
string dest_path = "C:/Users/tosun/C#_Projects/ConsoleApp_DosyaYonetimi/images/";

string[] files = Directory.GetFiles(source_path,"*",SearchOption.AllDirectories);


foreach(var file in files){
    Console.WriteLine(file);
    Console.WriteLine(Path.GetExtension(file)); //Dosya uzantisi verir.
    Console.WriteLine(Path.GetFileNameWithoutExtension(file)); //Uzantisiz file name
    Console.WriteLine(Path.GetFileName(file)); //Dosya ismini oldugu gibi verir.

    var info = new FileInfo(file); //Intance sinif oldugundan ornek uretilmelidir.

    Console.WriteLine($"{Path.GetFileName(file)}: {info.Length}");

    if(!Directory.Exists(dest_path))
    {
        Directory.CreateDirectory(dest_path);
    }

    //string name= Path.GetFileNameWithoutExtension(file) + "1-.jpg";
    string name = Path.GetRandomFileName() + Path.GetExtension(file); //Rsatgele dosya ismi olusturur.
    //File.Copy(file, $"{dest_path}{Path.GetFileName(file)}");
    File.Copy(file, $"{dest_path}{name}");
} 
