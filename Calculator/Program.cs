using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitLoop = true;
            int caseChoice;
            IMathOperations mathOperations;
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
                            mathOperations = new SumOperation();
                            mathOperations.MathOperation();
                            break;
                        case 2:
                            mathOperations = new SubtractionOperation();
                            mathOperations.MathOperation();
                            break;
                        case 3:
                            mathOperations = new MultiplyOperation();
                            mathOperations.MathOperation();
                            break;
                        case 4:
                            mathOperations = new DivideOperation();
                            mathOperations.MathOperation();
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
