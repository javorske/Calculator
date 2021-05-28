using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class MenuBuilder
    {
        public void DisplayMenu()
        {
            Console.WriteLine("Choose operation:");
            Console.WriteLine("1. Add.");
            Console.WriteLine("2. Subtract.");
            Console.WriteLine("3. Multiply.");
            Console.WriteLine("4. Divide.");
            Console.WriteLine("0. Quit.\n");
        }
    }
}
