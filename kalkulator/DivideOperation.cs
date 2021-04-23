using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class DivideOperation : NumbersGetter
    {
        OperationNumbers numbers;

        public override void MathOperation()
        {
            try
            {
                numbers = EnterNumbers();
                Console.WriteLine("Result of dividing is: {0}.", numbers.Number1 / numbers.Number2);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can't divide by zero.");
            }
            ClearConsole();
        }
    }
}
