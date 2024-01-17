// See https://aka.ms/new-console-template for more information

using Metodlar;

Urun urun1 = new Urun();
urun1.UrunAdi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya Elması";

Urun urun2 = new Urun();
urun2.UrunAdi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakır Karpuzu";

Urun[] urunler = new Urun[] {urun1, urun2 };

// Type Safe-TİP GÜVENLİ 
foreach ( Urun urun in urunler) // foreach ile gelen datayı tek tek ekrana basıyor urunlerin içinde tek tek dolanıp basıyor
{
    Console.WriteLine(urun.UrunAdi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("---------------------");
}
{
    Console.WriteLine("--------------METODLAR----------");

    //İnstance - örnek
    // fonksiyon metod

    SepetManager sepetManager = new SepetManager();
    sepetManager.Ekle(urun1);
    sepetManager.Ekle(urun2);

    sepetManager.Ekle2("Armut", "Yesil", 12, 10);
    sepetManager.Ekle2("Elma", "Kırmızı", 12, 20);
    sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 1);
}