using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrtaSeviye
{
    internal class Alan_Hesaplama  
                                    
    {
        public Alan_Hesaplama()
        {
            Console.WriteLine("İşlem yapmak istediğiniz şekli seçin  :   \n 1- Daire, 2- Kare, 3- Dikdörtgen, 4-Üçgen");

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1: Daire(); break;
                case 2: Kare(); break;
                case 3: Dikdortgen(); break;
                case 4: Ucgen(); break;

                default:
                    break;
            }
        }
        public static void Daire()
        {
            Console.WriteLine("Dairenin (1)-Alanını (2)-Çevresini (3)- Hacmini Hesaplatmak istiyorum");
            int daireinput = int.Parse(Console.ReadLine());
            if (daireinput == 1 || daireinput == 2)
            {
                Console.WriteLine("Hesaplamak istediğiniz çemberin yarı çapını girin");
                int yaricap = int.Parse(Console.ReadLine());
                if (daireinput == 1)
                {
                    int sonuc = yaricap * yaricap * 3;
                    Console.WriteLine(sonuc);
                }
                else if (daireinput == 2)
                {
                    int sonuc = yaricap * 2 * 3;
                    Console.WriteLine(sonuc);
                }
            }
            else if (daireinput == 3)
            {
                Console.WriteLine("Hesaplamak istediğiniz çemberin yarı çapını girin");
                int yaricap = int.Parse(Console.ReadLine());
                Console.WriteLine("Hesaplamak istediğiniz çemberin yüksekliini girin");
                int h = int.Parse(Console.ReadLine());
                int sonuc = yaricap * yaricap * 3 * h;
                Console.WriteLine(sonuc);
            }
        }
        public static void Kare()
        {
            Console.WriteLine("Karenin (1)-Alanını (2)-Çevresini (3)-Hacmini Hesaplatmak istiyorum : ");
            int kareinput = int.Parse(Console.ReadLine());
            Console.WriteLine("Karenin kenar uzunluğunu giriniz : ");

            int kenar = int.Parse(Console.ReadLine());
            if (kareinput == 1)
            {
                int sonuc = kenar * kenar;
                Console.WriteLine(sonuc);
            }
            else if (kareinput == 2)
            {
                int sonuc = kenar * 4;
                Console.WriteLine(sonuc);
            }
            else if (kareinput == 3)
            {
                int sonuc = kenar * kenar * kenar;
                Console.WriteLine(sonuc);
            }
        }
        public static void Dikdortgen()
        {
            Console.WriteLine("Dikdörtgenin (1)-Alanını (2)-Çevresini (3)-Hacmini Hesaplatmak istiyorum : ");
            int dikdoinput = int.Parse(Console.ReadLine());
            Console.WriteLine("Kısa kenar uzunluğunu giriniz : ");
            int kisa = int.Parse(Console.ReadLine());
            Console.WriteLine("Uzun kenar uzunluğunu giriniz : ");
            int uzun = int.Parse(Console.ReadLine());

            if (dikdoinput == 1)
            {
                int sonuc = kisa * uzun;
                Console.WriteLine(sonuc);
            }
            else if (dikdoinput == 2)
            {
                int sonuc = (kisa+uzun)*2;
                Console.WriteLine(sonuc);
            }
            else if (dikdoinput == 3)
            {
                Console.WriteLine(" Yükseklik uzunluğunu giriniz : ");
                int yuksek = int.Parse(Console.ReadLine());

                int sonuc = kisa * uzun * yuksek;
                Console.WriteLine(sonuc);
            }
        }
        public static void Ucgen ()
        {
            Console.WriteLine("Dik Üçgenin (1)-Alanını (2)-Çevresini (3)-Hacmini Hesaplatmak istiyorum : ");
            int ucgeninput = int.Parse(Console.ReadLine());
            Console.WriteLine("Kısa kenar uzunluğunu giriniz : ");
            int kisa = int.Parse(Console.ReadLine());
            Console.WriteLine("Uzun kenar uzunluğunu giriniz : ");
            int uzun = int.Parse(Console.ReadLine());

            if (ucgeninput == 1)
            {
                int sonuc = (kisa * uzun) / 2;
                Console.WriteLine(sonuc);
            }
            else if (ucgeninput == 2)
            {
                int hipokare = (kisa * kisa) + (uzun*uzun) ;
                double hipo = Math.Sqrt(hipokare);

                double sonuc = kisa + uzun + hipo;

                Console.WriteLine(sonuc);
            }
            else if (ucgeninput == 3)
            {
                Console.WriteLine(" Yükseklik uzunluğunu giriniz : ");
                int yuksek = int.Parse(Console.ReadLine());

                int sonuc = kisa * uzun * yuksek/2;
                Console.WriteLine(sonuc);
            }


        }
    }
}
