 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram236
{
    internal class SwappingNumbers
    {
        public void Swapping()
        {
            int temp = 0;
            Console.WriteLine("Enter The First Number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Second Number");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before Swapping:First:{0} Second:{1}", first, second);
            //temp = first;
            //first = second;
            //second = temp;
            first = first + second;
            second = first - second;
            first = first - second;

            Console.WriteLine("After Awapping:First:{0} second:{1}", first, second);
            Console.ReadLine();
        }
    }
}
