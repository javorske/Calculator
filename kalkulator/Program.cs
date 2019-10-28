using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz opcje:");
            Console.WriteLine("1. Dodawanie.");
            Console.WriteLine("2. Odejmowanie.");
            Console.WriteLine("3. Mnozenie.");
            Console.WriteLine("4. Dzielenie.");
            int check = int.Parse(Console.ReadLine());

            switch (check)
            {
                case 1:
                    Console.WriteLine(Dodawanie());
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        }
        public static int Dodawanie()
        { 
            Console.WriteLine("Podaj pierwsza liczbe");
            int liczba1 = int.Parse(Console.ReadLine());
            int liczba2 = int.Parse(Console.ReadLine());
            return liczba1 + liczba2;
        }
    }
}
