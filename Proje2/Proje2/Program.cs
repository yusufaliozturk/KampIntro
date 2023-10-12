// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string kurs1 = "Yazılım Geliştirme Kursu";
string kurs2 = "Programlamaya Giriş";
string kurs3 = "Java";
string kurs4 = "Php";

string[] kurslar = new string[]
{
    "Yazılım Geliştirme Kursu", "Programlamaya başlangıç için temel kurs", "Java", "Php"
};

for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}
Console.WriteLine("for döngüsü sonu");

foreach (string kurs in kurslar) 
{  Console.WriteLine(kurs);
}  
Console.WriteLine("------------------------");