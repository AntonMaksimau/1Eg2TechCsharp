using System;

namespace KartaPracy2
{
    
    class Program
    {
        
        static void Main()
        {
            
            // Zad 1
            /*
            int a = int.Parse(Console.ReadLine());
            if (a % 3 == 0)
            {
                Console.WriteLine("TAK");
            }
            else
            {
                Console.WriteLine("Nie");
            }
            */

            // Zad 2
            /*
            int a = int.Parse(Console.ReadLine());
            if (a > 99 && a < 1000 && a % 17 == 0)
            {
                Console.WriteLine("Tak");
            }
            else
            {
                Console.WriteLine("Nie");
            }
            */

            // Zad 3
            /*
            Console.Write("Podaj swój wiek: ");
            int wiek = int.Parse(Console.ReadLine());
            Console.WriteLine(wiek>=18 ? "TAK" : "NIE");
            */

            // Zad 4
            /*
            const int limit = 20;
            Console.Write("Waga: ");
            int waga = int.Parse(Console.ReadLine());
            Console.WriteLine(limit >= waga ? "Tak" : "Nie");
            */

            // Zad 5
            /*
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if ((a > c && c > b) || (b > c && c > a))
            {
                Console.WriteLine("Tak");
            }
            else
            {
                Console.WriteLine("Nie");
            }
            */

            // Zad 6
            /*
            int a = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            if ((Math.Pow(a, p) - a) % p == 0)
            {
                Console.WriteLine("TAK, spełnia MTF");
            }
            else
            {
                Console.WriteLine("NIE, nie spełnia MTF");
            }
            */

            // Zad 7
            /*
            uint p = uint.Parse(Console.ReadLine());
            uint k = uint.Parse(Console.ReadLine());
            uint s = uint.Parse(Console.ReadLine());
            Console.WriteLine(s * 3 >= k - p ? "Tak" : "Nie");
            */
        }
        
    }
    
}
