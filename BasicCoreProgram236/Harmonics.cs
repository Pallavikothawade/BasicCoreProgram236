using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram236
{
    class Harmonics
    {
        public void HarmonicsNumber()
        {
            int i;
            double s = 0.0;
            Console.WriteLine("Enter The Harmonic Number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("1/{0} + ", i);
                s += 1 / (float)i;
            }
            Console.WriteLine("\nsum of series upto {0} terms {1}\n", n, s);
        }
    }
}
