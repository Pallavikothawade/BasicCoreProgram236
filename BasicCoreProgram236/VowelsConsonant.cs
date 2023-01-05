using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram236
{
    internal class VowelsConsonant
    {
        public void Vowels()
        {

            Console.WriteLine("Enter The String");
            string Input = Console.ReadLine();
            for (int i = 0; i <= Input.Length - 1; i++)
            {
                if
                    (
                         (Input[i] >= 'a' && Input[i] <= 'z') ||
                         (Input[i] >= 'A' && Input[i] <= 'Z')
                       )
                {
                    if
                      (
                      Input[i] == 'a' || Input[i] == 'e' ||
                      Input[i] == 'i' || Input[i] == 'o' ||
                      Input[i] == 'u' || Input[i] == 'A' ||
                      Input[i] == 'E' || Input[i] == 'I' ||
                      Input[i] == 'O' || Input[i] == 'U'
                      )
                        Console.WriteLine("Input[i] is Vowels");
                    else
                        Console.WriteLine("Input[i] is Consonant");
                }
            }

        }
    }
}
