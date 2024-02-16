//Author: Pratik- C0899291

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
     class ExerciseLoop
    {
        static void Main()
        {
            int input = 0;
            bool isOutOfRange = false;
            do
            {
                Console.WriteLine("Please enter a positive number less than 10: ");
                input = int.Parse(Console.ReadLine());

                isOutOfRange = input < 1 || input >= 10;
                if (isOutOfRange)
                {
                    Console.WriteLine("Invalid input! Please Enter postive number less than 10");
                }

            } while (isOutOfRange);

            Console.WriteLine("Time table of number {0} is:", input);
            for(int i = 1; i < 10;i++) 
            { 
                Console.WriteLine(i + "*" + input + " = " + (i*input));
            }
        }
    }
}
