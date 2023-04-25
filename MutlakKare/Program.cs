using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrtaSeviye
{
    internal class Mutlak_Kare
    {
        public Mutlak_Kare()
        {
            Console.WriteLine("Boşluk birakarak sayilar girin : ");
            string input = Console.ReadLine();

            string[] strings = input.Split();

            int[] numbers = new int[strings.Length];

            int sumofDifferences = 0;
            double absoluteSquaring = 0;

            for (int i = 0; i < strings.Length; i++)
            {
                int x = int.Parse(strings[i]);
                numbers[i] = x;

                if (numbers[i] <= 67)
                {
                    sumofDifferences += 67 - numbers[i];
                    Console.WriteLine(" 67'den Küçük olanlarin farklarinin toplami :" + sumofDifferences);
                }
                else
                {
                    absoluteSquaring += Math.Pow((numbers[i] - 67), 2);
                    Console.WriteLine("67'den büyük farklarin mutlak karelerini alarak toplami : " + absoluteSquaring);
                }
            }

        }
    }
}