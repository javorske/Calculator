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
                             
                    Console.WriteLine("Choose operation:");
                    Console.WriteLine("1. Sum.");
                    Console.WriteLine("2. Substraction.");
                    Console.WriteLine("3. Multiplying.");
                    Console.WriteLine("4. Dividing.");
                    Console.WriteLine("0. Quit.\n");
                try
                {
                    caseChoice = int.Parse(Console.ReadLine());
                    switch (caseChoice)
                    {
                        case 1:
                            mathOperations.Sum();
                            break;
                        case 2:
                            mathOperations.Subtract();
                            break;
                        case 3:
                            mathOperations.Multiply();
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
