// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

{
    int sayi1 = 10;
    int sayi2 = 30;
    sayi1 = sayi2;
    sayi2 = 65;
    Console.WriteLine(sayi1);
    // sayi1=30


    int[] sayilar1 = new int[] { 10, 20, 30 };
    int[] sayilar2 = new int[] { 100, 200, 300 };
    sayilar1 = sayilar2;
    sayilar1[0] = 999;
    //sayilar1[0]=999
    Console.WriteLine(sayilar1[0]);

    // int,decimaş,float,double,bool = değer tip
    // array(liste),class,interface = referans tip

}