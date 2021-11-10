using System;

namespace Zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            // wczesniej: int powierzchnia = 100, osoby = 10;
            double powierzchnia = 100, osoby = 10; // int jest dla liczb calkowitych, nalezalo uzyc np. double
            double gestoscZaludnienia = osoby / powierzchnia;
            Console.WriteLine(gestoscZaludnienia);


        }
    }
}
