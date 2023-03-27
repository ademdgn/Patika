using System;

public class Hw2{
    public static void Main(String[] args){
        Console.WriteLine("20 tane sayi giriniz..");

        int[] arr = new int[20];

        for(int i= 0; i< 20; i++){
            Console.Write($"{i+1}.sayı : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            arr[i] = sayi;
        }
        Array.Sort(arr);

        int[] enbuyuk = new int[3];
        int[] enkucuk = new int[3];

       for (int i = 0; i < 3; i++)
       {
            enbuyuk[i] = arr[19-i];
            enkucuk[i] = arr[i];
       }

        Console.WriteLine($"En büyük 3 değer :");
        int toplam_b = 0;
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(enbuyuk[i]);
            toplam_b += enbuyuk[i];
        }
        Console.WriteLine($"Ortalaması : {toplam_b /3}");
        Console.WriteLine("*******************");


        Console.WriteLine($"En kucük 3 deger : ");
        int toplam_k = 0;
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(enkucuk[i]);
            toplam_k += enkucuk[i];
        }
        Console.WriteLine($"Ortalaması : {toplam_k /3}");
        Console.WriteLine(".");
     }
}
