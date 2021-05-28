using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendLogic
{
    public class NullOperation : IMathOperations
    {
        public object MathOperation()
        {
            return null;
        }
    }
}
