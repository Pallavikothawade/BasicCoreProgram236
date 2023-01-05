using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram236
{
    internal class CheckedRemainder
    {
        public void Remainder()
        {
            // int rem = 0,que=0;
            Console.WriteLine("Enter The  Divident Number");

            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Divisor Number");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int remainder;
            int quotient = Math.DivRem(dividend, divisor, out remainder);

            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);

            Console.ReadLine();

        }
    }
}
