﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class SumOperation : NumbersGetter
    {
        OperationNumbers numbers;

        public override void MathOperation()
        {
            numbers = EnterNumbers();
            Console.WriteLine("Result of sum is: {0}.",  numbers.Number1 + numbers.Number2);
            ClearConsole();
        }
    }
}
