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
            bool exitLoop = true;
            int check;
            do
            {
                try
                {
                
                    Console.WriteLine("Wybierz opcje:");
                    Console.WriteLine("1. Dodawanie.");
                    Console.WriteLine("2. Odejmowanie.");
                    Console.WriteLine("3. Mnozenie.");
                    Console.WriteLine("4. Dzielenie.");
                    check = int.Parse(Console.ReadLine());
                    switch (check)
                    {
                        case 1:
                            Dodawanie();
                            break;
                        case 2:
                            Odejmowanie();
                            break;
                        case 3:
                            Mnozenie();
                            break;
                        case 4:
                            Dzielenie();
                            break;
                        default:
                            SwitchDefault();
                            break;
                        case 0:
                            exitLoop = false;
                            break;
                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("Nie wybrano zadnej opcji, badz podano zly znak.");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (exitLoop);
        }
        public static void Dodawanie()
        { 
            Console.WriteLine("Podaj pierwsza liczbe: ");
            int liczba1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe: ");
            int liczba2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Wynik dodawania to: " + (liczba1 + liczba2) + ".") ;
            Console.ReadKey();
            Console.Clear();
        }
        public static void Odejmowanie()
        {
            Console.WriteLine("Podaj pierwsza liczbe: ");
            int liczba1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe: ");
            int liczba2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Wynik odejmowania to: " + (liczba1 - liczba2) + ".");
            Console.ReadKey();
            Console.Clear();
        }
        public static void Mnozenie()
        {
            Console.WriteLine("Podaj pierwsza liczbe: ");
            int liczba1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe: ");
            int liczba2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Wynik mnozenia to: " + (liczba1 * liczba2) + ".");
            Console.ReadKey();
            Console.Clear();
        }
        public static void Dzielenie()
        {
            Console.WriteLine("Podaj pierwsza liczbe: ");
            int liczba1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe: ");
            int liczba2 = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine("Wynik dzielenia to: " + (liczba1 / liczba2) + ".");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Nie mozna dzielic przez zero.");
            }
            Console.ReadKey();
            Console.Clear();
        }
        public static void SwitchDefault()
        {
            Console.WriteLine("Nie wybrano opcji.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
