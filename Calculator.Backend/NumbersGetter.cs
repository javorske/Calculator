using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendLogic
{
    public abstract class NumbersGetter
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
    }
}
