using System;

namespace ConsoleApp{
    class Program{
        public static void Main(String[] args ){


            // Fibonacci(); 
            // Tiangle();
            //Circle();
            //Algoritma();
            ReverseTitle();
        }

         public static void Fibonacci()   // Ortalama Hesaplama
    {
        Console.Write("Fibonacci seriniz kaç rakamdan oluşsun?");
        float derinlik = int.Parse(Console.ReadLine());

        float[] fibo = new float[(int)derinlik];
        fibo[0] = 0; fibo[1] = 1; fibo[2] = 1;   

        for(int i=3; i<fibo.Length; i++)
        {
            fibo[i] = fibo[i - 2] + fibo[i - 1];
        }

        float fiboort = fibo.Sum()/fibo.Length;

        Console.WriteLine(fiboort);        
    }

     public static void Triangle()    // Üçgen çizim
    {
        Console.Write("Üçgenin kenar uzunluğunu girin: ");
        int kenarUzunlugu = int.Parse(Console.ReadLine());

        for (int i = 1; i <= kenarUzunlugu; i++)
        {
            for (int j = 1; j <= kenarUzunlugu - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    public static void Circle()      // Çember çizim
    {
        Console.Write("Dairenin yarıçapını girin: ");
        int radius = int.Parse(Console.ReadLine());

        for (double y = -radius; y <= radius; y++)
        {
            for (double x = -radius; x <= radius; x += 0.5)
            {
                if ((x * x) + (y * y) >= radius * radius)
                    Console.Write(" ");
                else
                    Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    public static void Algoritma()
    {
        Console.Write("Bir kelime ve bir sayı giriniz (virgül ile ayırınız):    "   );
        string input = Console.ReadLine();
        string[] _input = input.Split(',');
        int sayi = int.Parse(_input[1]);
        Console.WriteLine(sayi);
        _input[0].Remove(sayi - 1);
        Console.WriteLine(_input[0].Remove(sayi-1,1));
        

              

       
        

    }
    public static void ReverseTitle()
    {
        Console.Write(" metin girin: ");
        string input = Console.ReadLine();
        string output = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            output += input[i];
        }

        Console.WriteLine("Ters Hali : " + output);
    }

    }
}
