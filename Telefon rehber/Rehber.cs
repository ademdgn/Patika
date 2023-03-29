using System;
using System.Threading;

namespace ConsoleApp
{
    class Rehber
    {
     

        Dictionary<string,int> rehberListe = new Dictionary<string, int>(); 



        public void NumaraEkleme(){
            Console.WriteLine("Lütfen adınızı giriniz..");
            string? name = Console.ReadLine();
            Console.WriteLine("Lütfen soyadınızı giriniz..");
            string? surname = Console.ReadLine();
            Console.WriteLine("Lütfen numaranızı giriniz..");
            int number =Convert.ToInt32( Console.ReadLine());

            if(name != null && surname != null ){
                rehberListe.Add(name+" "+surname,number);
                Console.WriteLine("Rehbere Kaydediliyor..");
                Thread.Sleep(2000);
            }else{
                Console.WriteLine("Girdiğiniz değerlerde uygun değil lütfen tekrar giriniz:");
                Console.WriteLine("************************");
                NumaraEkleme();
            }
           
            
         
        }

        public void NumaraSilme(){
            Console.WriteLine(" Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
             Console.WriteLine("Lütfen adınızı giriniz..");
            string? name = Console.ReadLine();
            Console.WriteLine("Lütfen soyadınızı giriniz..");
            string? surname = Console.ReadLine();
            if(name!= null && surname != null){

                string nameSurname = name+" "+surname;
            if(rehberListe[nameSurname]!= 0){
                 rehberListe.Remove(nameSurname);
                 Console.WriteLine("Numara siliniyor...");
                 Thread.Sleep(2000);
                 
            }else{
                bool islemyapildimi = true;
                while(islemyapildimi){

                     Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız...");
                    Console.WriteLine("  * Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine(" * Yeniden denemek için      : (2)");
                    int secim = Convert.ToInt32(Console.ReadLine());
                    if (secim == 1)
                    {
                        Console.WriteLine("Menüye Yönlendiriliyorsunuz ...");
                        Thread.Sleep(2000);
                        Menü();
                    }else if (secim == 2)
                    {
                
                    NumaraSilme();
                    }
                    else{
                        Console.WriteLine("Lütfen 1 ya da 2 giriniz...");

                    }
                }
               
            }

            }else
            {
                Console.WriteLine(" lütfen istenilen değerleri giriniz..");
                NumaraSilme();
            }
            
           
            
        }

        public void NumaraGüncelleme(){
            Console.WriteLine("Lütfen aramak istediğniz numaranın adını giriniz..");
            string? name = Console.ReadLine();
            Console.WriteLine("Lütfen aramak istediğniz numaranın soyadınızı giriniz..");
            string? surname = Console.ReadLine();

            if(name!= null && surname != null){
            string nameSurname = name+" "+surname;

            if(rehberListe[nameSurname] != 0){
                Console.WriteLine("Numarayı giriniz..");
                int number = Convert.ToInt32(Console.ReadLine());
                rehberListe[nameSurname] = number;
                Console.WriteLine("Numara Güncelleniyor ...");
                Thread.Sleep(2000);
            }else{
                bool islemyapildimi = true;
                while(islemyapildimi){
                     Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine(" * Güncellemeyi sonlandırmak için    : (1)");
                    Console.WriteLine(" * Yeniden denemek için              : (2)");
                    int sec = Convert.ToInt32(Console.ReadLine());

                    if (sec == 1)
                    {
                        Console.WriteLine("Menüye yönlendiriliyorsunuz..");
                        Thread.Sleep(2000);
                        islemyapildimi = false;
                    }
                    else if(sec == 2)
                    {
                        NumaraGüncelleme();   
                    }else{
                        Console.WriteLine("Lütfen 1 ya da 2 giriniz...");
                    }

                }
               
            }
            }else
            {
                Console.WriteLine("istenilen karakterleri kullanarak giriniz..");
                Console.WriteLine("Menüye yönlendiriliyorsunuz...");
                        Thread.Sleep(2000);

                
            }
            
        }

        public void RehberiGösterme(){
            foreach (var kisiler in rehberListe)
            {
                Console.WriteLine($"{kisiler.Key} : {kisiler.Value}");
            }

        }

        public void RehberdeArama(){
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

            int secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1)
            {
                Console.WriteLine("isim giriniz : ");
                string? Name = Convert.ToString(Console.ReadLine());
                Console.WriteLine(" soyisim giriniz :");
                string? Surname = Convert.ToString(Console.ReadLine());

                if(Name != null && Surname!= null){
                    string nameSurname = Name+" "+Surname;

                    int yeni_kullanici =123456789;

                    bool Varmi = rehberListe.TryGetValue(nameSurname,out yeni_kullanici);
                    if (Varmi)
                    {
                        Console.WriteLine("Bu isim soyisim de bir kullanici mevcuttur.");
                        Console.WriteLine($"isim soyisim : { nameSurname}");
                        Console.WriteLine($"numara : {rehberListe[nameSurname]}");
                    }
                    else{
                        Console.WriteLine("Böyle bir kişi bulunamamıştır..");
                        Console.WriteLine("Menüye yönlendiriliyorsunuz...");
                        Thread.Sleep(3000);
                    }
                } 
            }
        }
        
        public void Menü(){
            bool Exit = true;
            while (Exit){

                Console.WriteLine("  Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("******************************************** ");
            Console.WriteLine(" (1) Yeni Numara Kaydetmek ");
            Console.WriteLine(" (2) Varolan Numarayı Silmek");
            Console.WriteLine("  (3) Varolan Numarayı Güncelleme");
            Console.WriteLine("  (4) Rehberi Listelemek");
            Console.WriteLine(" (5) Rehberde Arama Yapmak﻿");
            Console.WriteLine(" Cıkış yapmak için 6 ya basın");
            int secim = Convert.ToInt32(Console.ReadLine());
            
            switch (secim)
            {
                case  1:
                    NumaraEkleme();
                    break;
                case  2:
                    NumaraSilme();
                    break;
                case 3:
                    NumaraGüncelleme();
                    break;
                case 4:
                    RehberiGösterme();
                    break;
                case 5:
                    RehberdeArama();
                    break;
                case 6:
                    Exit = false;
                    break;
                default:
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz");
                    break;
                
            }

            }
           
        }
    }
}
