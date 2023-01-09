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
            Console.WriteLine("1:FlipCoin\n2:Checked Leap Year\n3:Factors\n4:Swap Two Numbers\n5:Vowels and Consonant\n6:Checked Remainder\n7:Even Or Odd\n8:Large Number\n9:Harmonic Number\n10:Power Of Two\n");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch (Option)
            {
                case 1:
                    FlipcoinProgram fp = new FlipcoinProgram();
                    fp.HeadTail();
                    break;
                case 2:
                    LeapYear lp = new LeapYear();
                    lp.check();
                    break;
                case 3:
                    FactorsProgram factorsProgram = new FactorsProgram();
                    factorsProgram.fact();
                    break;
               
                case 4:
                    SwappingNumbers swappingNumbers = new SwappingNumbers();
                    swappingNumbers.Swapping();
                    break;
                case 5:
                    VowelsConsonant vowelsConsonant = new VowelsConsonant();
                    vowelsConsonant.Vowels();
                    break;
                case 6:
                    CheckedRemainder checkedRemainder = new CheckedRemainder();
                    checkedRemainder.Remainder();
                    break;
                case 7:
                    EvenOdd evenOdd = new EvenOdd();
                    evenOdd.EvenoroddNumber();
                    break;
                case 8:
                    LargeNumber largeNumber = new LargeNumber();
                    largeNumber.Large();
                        break;

                    //default:
                    //    break;
            }
                    Console.ReadLine();
        }
    }
}
