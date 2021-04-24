using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    abstract class NumbersGetter : IMathOperations
    {
        public OperationNumbers EnterNumbers()
        {
            Console.Clear();
            OperationNumbers numbers = new OperationNumbers();
            Console.WriteLine("Enter first number: ");
            numbers.Number1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            numbers.Number2 = decimal.Parse(Console.ReadLine());
            return numbers;
        }
        public void ClearConsole()
        {
            Console.ReadKey();
            Console.Clear();
        }
        public abstract void MathOperation();
    }
}
