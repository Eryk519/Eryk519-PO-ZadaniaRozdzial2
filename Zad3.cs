using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float waga, wzrost, BMI;
            Console.WriteLine("Podaj swoja wage w kilogramach:");
            waga = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swoj wzrost w metrach:");
            wzrost = float.Parse(Console.ReadLine());
            BMI = waga / (wzrost * wzrost);
            Console.WriteLine("Twoje BMI wynosi:" + BMI);
            Console.ReadLine();

        }
    }
}
