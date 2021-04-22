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
            int caseChoice;
            MathOperations mathOperations = new MathOperations();
            do
            {
                try
                {                
                    Console.WriteLine("Wybierz opcje:");
                    Console.WriteLine("1. Dodawanie.");
                    Console.WriteLine("2. Odejmowanie.");
                    Console.WriteLine("3. Mnozenie.");
                    Console.WriteLine("4. Dzielenie.");
                    Console.WriteLine("0. Zakończ.");
                    caseChoice = int.Parse(Console.ReadLine());
                    switch (caseChoice)
                    {
                        case 1:
                            mathOperations.Sum();
                            break;
                        case 2:
                            mathOperations.Subtraction();
                            break;
                        case 3:
                            mathOperations.Multiplication();
                            break;
                        case 4:
                            mathOperations.Divide();
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
        
        public static void SwitchDefault()
        {
            Console.WriteLine("Nie wybrano opcji.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
