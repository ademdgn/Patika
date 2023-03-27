using System;
using System.Collections;
public class Hw2{
    public static void Main(String[] args){
        Console.Write("Bir cümle giriniz ..");
        string cumle = Console.ReadLine();
        char[] sesli = {'a','e','ı','i','o','ö','u','ü'};

        ArrayList dizi = new ArrayList();

        if(!string.IsNullOrEmpty(cumle)){
            foreach (char item in cumle)
            {
                foreach (char sesliler in sesli)
                {
                    if(item == sesliler){
                        dizi.Add(sesliler);
                    }
                }
            }
        }
        dizi.Sort();
        for (int i = 0; i < dizi.Count; i++)
        {
            Console.WriteLine(dizi[i]);
        }

     }
}
