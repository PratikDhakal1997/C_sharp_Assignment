//Author: Pratik Dhakal. C0899291

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
     class Degree3
    {
        static void Main()
        {
            Console.WriteLine("Enter a (int): ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter b (int): ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter c (int): ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter x (double): ");
            double x = double.Parse(Console.ReadLine());

            // Calculate intermediate values f
            double abDiv2 = (a + b) / 2.0;
            double aPlusB = a + b;

            // Evaluate square and cube of x
            double xSquared = x * x;
            double xCubed = x * x * x;

            //evaluate a 3rd degree polynomial
            double result = abDiv2 * xCubed + aPlusB * aPlusB * xSquared + aPlusB + c;

            //output
            Console.WriteLine($"The value of the polynomial is: {result}");
        }
    }
}
