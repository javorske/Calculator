using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendLogic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitLoop = true;
            bool isInputCorrect;
            BackendLogic.IMathOperations mathOperations;

            do
            {
                Console.WriteLine("Choose operation:");
                Console.WriteLine("1. Add.");
                Console.WriteLine("2. Subtract.");
                Console.WriteLine("3. Multiply.");
                Console.WriteLine("4. Divide.");
                Console.WriteLine("0. Quit.\n");
                isInputCorrect = int.TryParse(Console.ReadLine(), out int caseChoice);
                if (isInputCorrect)
                {
                    mathOperations = new BackendLogic.NullOperation();

                    switch (caseChoice)
                    {
                        case 1:
                            mathOperations = new BackendLogic.SumOperation();
                            break;
                        case 2:
                            mathOperations = new BackendLogic.SubtractionOperation();
                            break;
                        case 3:
                            mathOperations = new BackendLogic.MultiplyOperation();
                            break;
                        case 4:
                            mathOperations = new BackendLogic.DivideOperation();
                            break;
                        case 0:
                            exitLoop = false;
                            break;
                        default:
                            PrintNoOptionSelected();
                            break;
                    }
                    ResultDisplayer dis = new ResultDisplayer();
                    dis.displayResult(mathOperations.MathOperation());
                }
                else
                {
                    PrintNoOptionSelected();
                }
            } while (exitLoop);
        }
        
        public static void PrintNoOptionSelected()
        {
            Console.WriteLine("No option selected or wrong character entered.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
