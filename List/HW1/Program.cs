
using System;
using System.Collections;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[20];

            ArrayList asal_sayilar = new ArrayList();
            ArrayList asal_olmayanlar = new ArrayList();

            string[] incorrectly = new string[20];

            int sayi_sayisi = 20;

            for (int i = 0; i < sayi_sayisi; i++)
            {

                Console.WriteLine("Sayi Giriniz ? :");

                int sayi = 0;
                string girilen = Console.ReadLine();



                if (Int32.TryParse(girilen, out sayi))
                {
                    if (sayi > 1)
                    {
                        sayilar[i] = sayi;
                    }
                    else
                    {
                        sayi_sayisi++;
                    }
                }
                else
                {
                    
                    Console.WriteLine("Pozitif tam sayi giriniz ");
                    Console.WriteLine(" ");
                    sayi_sayisi++;
                }


            }

            for (int i = 0; i < 20; i++)
            {
                if (AsalSayi(sayilar[i]) == 1)
                {
                    asal_sayilar.Add(sayilar[i]);

                }
                else
                {

                    asal_olmayanlar.Add(sayilar[i]);
                }
            }

            int AsalSayi(int sayilara)
            {
                int sayac = 0;
                if (sayilara > 1)
                {
                    for (int i = 2; i < sayilara; i++)
                    {
                        if (sayilara % i == 0)
                        {
                            sayac++;
                        }
                    }

                }
                else
                {
                    sayac++;
                }

                return sayac == 0 ? 1 : 0;
            }

            asal_olmayanlar.Sort();
            asal_sayilar.Sort();

            Console.WriteLine("*********************");
            Console.WriteLine("Asal Olamayan Sayilar");

            Console.WriteLine("*********************");
            int asalolmayan_toplam = 0;

            foreach (int item in asal_olmayanlar)
            {
                Console.WriteLine(item.ToString());
                asalolmayan_toplam += item;

            }
          
            


            int asalolmayan_ortalama = asalolmayan_toplam / asal_olmayanlar.Count;
            Console.WriteLine($"Asal olmayanlar toplamı: {asalolmayan_toplam}");
            Console.WriteLine($"Asal olmayanlar elaman sayısı:{asal_olmayanlar.Count}");
            Console.WriteLine($"Asal olmayanlar ortalama: {asalolmayan_ortalama}");

            Console.WriteLine("*********************");
            Console.WriteLine("Asal  Sayilar");
            Console.WriteLine("*********************");
            int asal_toplam = 0;

            foreach (int a in asal_sayilar)
            {
                Console.WriteLine(a.ToString());
                asal_toplam += a;

            }
            int asal_ortalama = asal_toplam / asal_sayilar.Count;

            Console.WriteLine($"Asal olan toplamı: {asal_toplam}");
            Console.WriteLine($"Asal  olan elaman sayısı:{asal_sayilar.Count}");
            Console.WriteLine($"Asal   olan ortalama: {asal_ortalama}");

        }
    }
}

