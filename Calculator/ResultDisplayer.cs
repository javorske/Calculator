using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ResultDisplayer
    {
        public void displayResult(object resultNumbers)
        {
            if (resultNumbers is Exception )
            {
                Console.WriteLine("You can't divide by zero.");
                Console.ReadKey();
            }
            else if (resultNumbers != null)
            {
                Console.WriteLine("The result is: {0}", resultNumbers);
                Console.ReadKey();
            }
            Console.Clear();
        }
    }
}
