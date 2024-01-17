// See https://aka.ms/new-console-template for more information
{

    //type safety- tip güvenliği
    //Do NOT repeat yourself- Kendini tekrarlama 
    // DEĞER TUTUCU, ALİAS
    
    string kategoriEtiketi = "Kategoriler";
    int ogreciSayisi = 32000;
    double faizOrani = 1.45;
    bool sistemeGirisYapmısMi = false;
    double dolarDun = 7.55;
    double dolarBugun = 7.45;

    if (dolarDun>dolarBugun)

    {
        Console.WriteLine("Azalış Butonu");
    }
    else if (dolarDun<dolarBugun)
    {
        Console.WriteLine("Artış Butonu");
    }
    else
    {
        Console.WriteLine("Değişmedi Butonu");
    }




    if (sistemeGirisYapmısMi== true)
    {
        Console.WriteLine("Kullanıcı Ayarları butonu");
    }
    else
    {
        Console.WriteLine("Sisteme Giriş Yap");
    }
    Console.WriteLine(kategoriEtiketi);
}


