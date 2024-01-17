// See https://aka.ms/new-console-template for more information
{
    string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
    string kurs2 = "Programlamaya başlangıç İçin Temel Kurs";
    string kurs3 = "Java";
    // aray-dizi 

    string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
        "Programlamaya başlangıç İçin Temel Kurs", "Java","Python" };

    for (int i = 0; i<kurslar.Length; i++)
    {
        Console.WriteLine(kurslar[i]);
    }

    Console.WriteLine("FOR BİTTİ ");

    foreach (string kurs in kurslar)
    {
        Console.WriteLine(kurs);   
    }

    Console.WriteLine("Sayfa Sonu- footer");
} 