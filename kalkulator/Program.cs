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
                    Dodawanie();
                    break;
                case 2:
                    Odejmowanie();
                    break;
                default:
                    break;
            }
        }
        public static void Dodawanie()
        { 
            Console.WriteLine("Podaj pierwsza liczbe: ");
            int liczba1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe: ");
            int liczba2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Wynik to: " + (liczba1 + liczba2) + ".") ;
            Console.ReadKey();
        }
        public static void Odejmowanie()
        {
            Console.WriteLine("Podaj pierwsza liczbe: ");
            int liczba1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe: ");
            int liczba2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Wynik to: " + (liczba1 - liczba2) + ".");
            Console.ReadKey();
        }
    }
}
