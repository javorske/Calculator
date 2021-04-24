using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class SubtractionOperation : NumbersGetter
    {
        OperationNumbers numbers;

        public override void MathOperation()
        {
            numbers = EnterNumbers();
            Console.WriteLine("Result of subtraction is: {0}.", numbers.Number1 - numbers.Number2);
            ClearConsole();
        }
    }
}
