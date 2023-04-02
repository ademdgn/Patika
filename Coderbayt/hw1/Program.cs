using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = " adem Dogan";
            MainClass mainClass = new MainClass();
            string[] s = str.Split(' ');
          Console.WriteLine(WordCount(Console.ReadLine()));
        }
    }
    class MainClass {

  public static string WordCount(string str) {

    string[] s;

    s = str.Split(" "); 
   
    int a = s.Count();

    return Convert.ToString(a);

  }
}
}
