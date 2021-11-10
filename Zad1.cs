using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float stopniec, stopnief;
            Console.WriteLine("Podaj stopnie w celsjuszach");
            stopniec = float.Parse(Console.ReadLine());
            stopnief = stopniec * 9 / 5 + 32;
            Console.WriteLine("Temperatura w stopniach Farenheita wynosi:");
            Console.WriteLine(stopnief);
        }
    }
}
