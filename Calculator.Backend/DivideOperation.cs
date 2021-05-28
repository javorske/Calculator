using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendLogic
{
    public class DivideOperation : NumbersGetter, IMathOperations
    {
        OperationNumbers numbers;
        decimal result;

        public object MathOperation()
        {
            try
            {
                numbers = EnterNumbers();
                result = numbers.Number1 / numbers.Number2;
                return result;
            }
            catch (DivideByZeroException ex)
            {
                return ex;
            }
        }
    }
}
