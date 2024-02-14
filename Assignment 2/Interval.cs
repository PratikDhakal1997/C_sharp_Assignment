//Author: Pratik Dhakal C0899291

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    class Interval
    {
        static void Main()
        {
            while (true)
            {
                //prompt user for input
                Console.Write("Enter a real number (or press 'y' to exit): ");

                double x;
                //take input from user
                string input = Console.ReadLine();

                // try parsing the input to double
                if (!double.TryParse(input, out x))
                {
                    
                    if (input.ToLower() == "y")
                    {
                        break; // if input is 'y' exit the program
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid real number.");
                        continue; // Skip the rest of the loop and ask for input again
                    }                
                }

                bool xBelongsToI = false;

                //only using < and == Operators
                if (((2 < x || x == 2) && x < 3) || (0 < x && (x < 1 || x == 1)) || ((-10 < x || x== -10) && (x < -2 || x==-2)))
                {
                    xBelongsToI = true;
                }

                if (xBelongsToI)
                {
                    Console.WriteLine("x belongs to I");
                }
                else
                {
                    Console.WriteLine("x does not belong to I");
                }
            }
        }
    }
}
