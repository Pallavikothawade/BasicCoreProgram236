using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram236
{
    class FlipcoinProgram
    {
        public void HeadTail()
        {
            int tailcount = 0, headcount = 0;
            Console.WriteLine("Number of Times to the flipcoin");
            int n = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();

            for (int i = 1; i <= n; i++)
            {
                double input = random.NextDouble();
                if (input < 0.5)
                    tailcount++;
                else
                    headcount++;
            }
            Console.WriteLine("Tailcount:{0} Headcount:{1}", tailcount, headcount);
            double tailpercentage = (tailcount * 100) / 10;
            double headpercentage = (headcount * 100) / 10;
            Console.WriteLine("Tail={0}% headpercentage={1}%", tailpercentage, headpercentage);
            Console.ReadLine();
        }
    }
}
