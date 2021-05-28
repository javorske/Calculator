using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class MultiplyOperation : NumbersGetter, IMathOperations
    {
        OperationNumbers numbers;

        public void MathOperation()
        {
            numbers = EnterNumbers();
            Console.WriteLine("Result of multiplication is: {0}.", numbers.Number1 * numbers.Number2);
            ClearConsole();
        }
    }
}
