using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram236
{
    class Powerof
    {
        public void Powertwo()
        {
            int a = 1;
            Console.WriteLine("Enter The number");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 31)
            {
                Console.WriteLine("We Can not calculate");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    a = 2 * a;
                }
                Console.WriteLine(a);

            }
        }

    }
}
