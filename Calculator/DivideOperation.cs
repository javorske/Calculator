﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class DivideOperation : NumbersGetter, IMathOperations
    {
        OperationNumbers numbers;

        public void MathOperation()
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
