using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendLogic
{
    public class SumOperation : NumbersGetter, IMathOperations
    {
        OperationNumbers numbers;
        decimal sum;

        public object MathOperation()
        {
            numbers = EnterNumbers();
            sum = numbers.Number1 + numbers.Number2;
            return sum;
        }
    }
}
