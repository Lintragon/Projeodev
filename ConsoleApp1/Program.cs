using System;
using System.Linq.Expressions;

namespace ConsoleApp1
{
    internal class Program
    {
        private static int o;
        private static int toplam;
        private static int ort;
        static void Main(string[] args)

        {
            try
            {




                Console.WriteLine("Kaç öğrenci kayıt etmek istiyorsunuz ?");
                int n = int.Parse(Console.ReadLine());
                int m = 0;







                for (int k = m; k < n; k++)
                {
                    Console.WriteLine($"öğrenci numarasını  giriniz:");
                    long num = long.Parse(Console.ReadLine());


                    Console.WriteLine($"öğrenci adını giriniz:");
                    string ad = Console.ReadLine();
                    Console.WriteLine($"öğrenci soyadını giriniz:");
                    string soyad = Console.ReadLine();
                    Console.WriteLine($"öğrenci vize notunu giriniz:");
                    byte v = byte.Parse(Console.ReadLine());
                    if ( v >= 0 && v >= 101 )
                    {
                        Console.WriteLine("Lütfen 0 ile 100 arasında bir değer giriniz");
                        break;
                    }
                    
                   

                    Console.WriteLine($"öğrenci final notunu giriniz:");
                    byte f = byte.Parse(Console.ReadLine());

                    if (f >= 0 && f >= 101)
                    {
                        Console.WriteLine("Lütfen 0 ile 100 arasında bir değer giriniz");
                        break;
                    }

                    var viz = v * 0.4f;
                    var fin = f * 0.6f;
                    var o = viz + fin;

                    for (int i = 0; i < n; i++)
                    {
                        toplam += (int)o;
                        ort = toplam / n;
                    }

                    int enBuyuk = (int)o;
                    for (int i = 0; i < (int)o; i++)
                    {
                        if (o > enBuyuk)
                        {
                            enBuyuk = (int)o;
                        }
                      
                    }
                    int enKucuk = (int)o;
                    for (int i = 0; i < (int)o; i++)
                    {
                        if (o < enKucuk)
                        {
                            enKucuk = (int)o;
                        }

                    }



                    if (o >= 85)
                    {
                        string a = "AA";

                        Console.WriteLine($"Öğrenci:| Numarası   | Adı   |  Soyadı  | Fize notu |  Final notu|  Ortalama  | Harf notu  ");
                        Console.WriteLine($"         {num}      {ad}    {soyad}      {v}         {f}          {o}          {a}");
                    }
                    else if (o >= 75)
                    {
                        string a = "BB";
                        Console.WriteLine($"Öğrenci:| Numarası   | Adı   |  Soyadı  | Fize notu |  Final notu|  Ortalama  | Harf notu  ");
                        Console.WriteLine($"         {num}      {ad}    {soyad}      {v}         {f}          {o}          {a}");
                    }
                    else if (o >= 60)
                    {
                        string a = "BB";
                        Console.WriteLine($"Öğrenci:| Numarası   | Adı   |  Soyadı  | Fize notu |  Final notu|  Ortalama  | Harf notu  ");
                        Console.WriteLine($"         {num}      {ad}    {soyad}      {v}         {f}          {o}          {a}");
                    }
                    else if (o >= 50)
                    {
                        string a = "CB";
                        Console.WriteLine($"Öğrenci:| Numarası   | Adı   |  Soyadı  | Fize notu |  Final notu|  Ortalama  | Harf notu  ");
                        Console.WriteLine($"         {num}      {ad}    {soyad}      {v}         {f}          {o}          {a}");
                    }
                    else if (o >= 40)
                    {
                        string a = "CC";
                        Console.WriteLine($"Öğrenci:| Numarası   | Adı   |  Soyadı  | Fize notu |  Final notu|  Ortalama  | Harf notu  ");
                        Console.WriteLine($"         {num}      {ad}    {soyad}      {v}         {f}          {o}          {a}");
                    }
                    else if (o >= 30)
                    {
                        string a = "DC";
                        Console.WriteLine($"Öğrenci:| Numarası   | Adı   |  Soyadı  | Fize notu |  Final notu|  Ortalama  | Harf notu  ");
                        Console.WriteLine($"         {num}      {ad}    {soyad}      {v}         {f}          {o}          {a}");
                    }
                    else if (o >= 20)
                    {
                        string a = "DD";
                        Console.WriteLine($"Öğrenci:| Numarası   | Adı   |  Soyadı  | Fize notu |  Final notu|  Ortalama  | Harf notu  ");
                        Console.WriteLine($"         {num}      {ad}    {soyad}      {v}         {f}          {o}          {a}");

                    }
                    else if (o >= 10)
                    {
                        string a = "FD";
                        Console.WriteLine($"Öğrenci:| Numarası   | Adı   |  Soyadı  | Fize notu |  Final notu|  Ortalama  | Harf notu  ");
                        Console.WriteLine($"         {num}      {ad}    {soyad}      {v}         {f}          {o}          {a}");
                    }
                    else
                    {
                        string a = "FF";
                        Console.Write($"Öğrenci: Numarası \n{num} Adı \n{ad} Soyadı \n{soyad} Fize notu \n{v} Final notu \n{f} Ortalama \n{o} Harf notu \n{a} ");
                    }
                    Console.WriteLine($"sınıftaki en yüksek not:  {enBuyuk}");
                    Console.WriteLine($"sınıftaki en düşük not:  {enKucuk}");
                    Console.WriteLine($"sınıf ortalaması: {ort}");






                }


            }
            catch (OverflowException v)
            {
                Console.WriteLine("Cok yüksek değer girdiniz ! Lütfen 1000 ve üstü sayılara çıkmayın");
            }
            catch (FormatException)
            {
                Console.WriteLine("Öğrenci sayısını ve okul numaranızı sayı ile giriniz");
            }

            
            
        }
    }
}
