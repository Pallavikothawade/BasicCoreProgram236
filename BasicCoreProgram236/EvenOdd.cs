using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram236
{
    class EvenOdd
    {
        public void EvenoroddNumber()
        {
            for (int i = 0; i <= 50; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("{0} This is Even Number" + i);
                else
                    Console.WriteLine("{1} This is Odd Number" + i);
            }
        }
    }
}
