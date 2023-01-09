using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram236
{
    class LargeNumber
    {
        public void Large()
        {
            int Num1, Num2, Num3;
            Console.WriteLine("Enter The First Number");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Second Number");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Third Number");
            Num3 = Convert.ToInt32(Console.ReadLine());
            if (Num1 > Num2)
            {
                if (Num1 > Num3)
                {
                    Console.WriteLine("The First Number is the greatest among three");
                }
                else
                {
                    Console.WriteLine("The Third Number is the greatest among three");
                }
            }
            else if (Num2 > Num3)
                Console.WriteLine("The Second Number is the greatest among three");
            else
                Console.WriteLine("The Third Number is the greatest among three");

        }
    }
}
