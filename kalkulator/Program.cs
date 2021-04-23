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
            do
            {                             
                    Console.WriteLine("Choose operation:");
                    Console.WriteLine("1. Add.");
                    Console.WriteLine("2. Subtract.");
                    Console.WriteLine("3. Multiply.");
                    Console.WriteLine("4. Divide.");
                    Console.WriteLine("0. Quit.\n");
                try
                {
                    caseChoice = int.Parse(Console.ReadLine());
                    switch (caseChoice)
                    {
                        case 1:
                            SumOperation sum = new SumOperation();
                            sum.MathOperation();
                            break;
                        case 2:
                            SubtractionOperation subtraction = new SubtractionOperation();
                            subtraction.MathOperation();
                            break;
                        case 3:
                            MultiplyOperation multiplication = new MultiplyOperation();
                            multiplication.MathOperation();
                            break;
                        case 4:
                            DivideOperation division = new DivideOperation();
                            division.MathOperation();
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
                    Console.WriteLine("No option selected or wrong character entered.");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (exitLoop);
        }
        
        public static void SwitchDefault()
        {
            Console.WriteLine("No option selected.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
