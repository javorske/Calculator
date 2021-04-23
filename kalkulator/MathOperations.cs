using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    public class MathOperations
    {
        int[] numberArr;
        public void Sum()
        {
            numberArr = EnterNumbers();
            Console.WriteLine("Result of sum is: " + (numberArr[0] + numberArr[1]) + ".");
            ClearConsole();
        }

        public void Subtract()
        {
            numberArr = EnterNumbers();
            Console.WriteLine("Result of substracting is: " + (numberArr[0] - numberArr[1]) + ".");
            ClearConsole();
        }

        public void Multiply()
        {
            numberArr = EnterNumbers();
            Console.WriteLine("Result of multiplying is: " + (numberArr[0] * numberArr[1]) + ".");
            ClearConsole();
        }

        public void Divide()
        {
            try
            {
                numberArr = EnterNumbers();
                Console.WriteLine("Result of dividing is: " + (numberArr[0] / numberArr[1]) + ".");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can't divide by zero.");
            }
            ClearConsole();
        }

        private int[] EnterNumbers()
        {
            Console.Clear();
            int[] numArr = new int[2];
            Console.WriteLine("Enter first number: ");
            numArr[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            numArr[1] = int.Parse(Console.ReadLine());
            return numArr;
        }
        private void ClearConsole()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}
