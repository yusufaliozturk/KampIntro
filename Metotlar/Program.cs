using System;

internal class Urun
{
    public int Id { get; set; }
    public string Adi { get; set; }
    public double Fiyati { get; set; }
    public string Aciklama { get; set; }
    public int StokAdedi { get; set; }
}

internal class SepetManager
{
    public void Ekle(Urun urun)
    {
        Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);
    }

    public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
    {
        Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Urun urun1 = new Urun();
        urun1.Adi = "Elma";
        urun1.Fiyati = 15;
        urun1.Aciklama = "Amasya elması";

        Urun urun2 = new Urun();
        urun2.Adi = "Karpuz";
        urun2.Fiyati = 80;
        urun2.Aciklama = "Diyarbakır karpuzu";

        Urun[] urunler = new Urun[] { urun1, urun2 };

        foreach (var urun in urunler)
        {
            Console.WriteLine(urun.Adi);
            Console.WriteLine(urun.Fiyati);
            Console.WriteLine(urun.Aciklama);
            Console.WriteLine("--------------------");
        }

        Console.WriteLine("------------Metotlar---------------");

        SepetManager sepetManager = new SepetManager();
        sepetManager.Ekle(urun1);
        sepetManager.Ekle(urun2);

        sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
        sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
        sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);
    }
}
