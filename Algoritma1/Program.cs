using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Kaç tane sayı gireceğinizi yazınız?");
           int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

           for(int i = 0; i < n ; i++){
                Console.WriteLine("Sayı Giriniz ?");
                int a = Convert.ToInt32(Console.ReadLine());
                arr[i] = a;
           }

            Console.WriteLine($"Girdiğiniz sayılarda çift olan sayılar");
           for (int i = 0; i < n; i++)
           {
        
            if((arr[i]%2)==0){
                Console.WriteLine(arr[i]);
                
            }
            
           }
        }
    }
}