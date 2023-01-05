using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram236
{
    class FactorsProgram
    {
        public void fact()
        {
            int fact = 1;
            Console.WriteLine("Enter The Number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial is: " + fact);
        }
    }
}
