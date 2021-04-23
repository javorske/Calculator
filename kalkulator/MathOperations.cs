using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    public class MathOperations
    {
        public void Sum()
        {
            Console.WriteLine("Podaj pierwsza liczbe: ");
            int liczba1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe: ");
            int liczba2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Wynik dodawania to: " + (liczba1 + liczba2) + ".");
            Console.ReadKey();
            Console.Clear();
        }

        public void Subtract()
        {
            Console.WriteLine("Podaj pierwsza liczbe: ");
            int liczba1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe: ");
            int liczba2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Wynik odejmowania to: " + (liczba1 - liczba2) + ".");
            Console.ReadKey();
            Console.Clear();
        }

        public void Multiply()
        {
            Console.WriteLine("Podaj pierwsza liczbe: ");
            int liczba1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe: ");
            int liczba2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Wynik mnozenia to: " + (liczba1 * liczba2) + ".");
            Console.ReadKey();
            Console.Clear();
        }

        public void Divide()
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
    }
}
