using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram236
{
    class LeapYear
    {
        public void check()
        {
            Console.WriteLine("Enter The Year");
            int year = Convert.ToInt32(Console.ReadLine());

            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                Console.WriteLine("{0} is Leap Year", year);
            else
                Console.WriteLine("{0} is Not Leap Year", year);
            Console.ReadLine();
        }
    }
}
