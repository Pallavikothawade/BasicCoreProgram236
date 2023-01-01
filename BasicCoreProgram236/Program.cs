using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram236
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome The Basic Program");
            Console.WriteLine("Enter The Choose One Option");
            Console.WriteLine("1:FlipCoin\n2:Checked Leap Year\n3:Factors\n4:Checked Remainder\n5:Swap Two Numbers\n6:Vowels and Consonant\n7:Even Or Odd\n8:Large Number\n9:Harmonic Number\n10:Power Of Two\n");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch (Option)
            {
                case 1:
                    FlipcoinProgram fp = new FlipcoinProgram();
                    fp.HeadTail();
                    break;
                //default:
                //    break;
            }
                    Console.ReadLine();
        }
    }
}
