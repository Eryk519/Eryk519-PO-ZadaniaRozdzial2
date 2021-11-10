using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x0, x1, x2;
            Console.WriteLine("Podaj a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c");
            c = double.Parse(Console.ReadLine());
            delta = b * b - 4 * a * c;
            Console.WriteLine("Delta wynosi:" + delta);
            Console.ReadKey();








        }
    }
}
