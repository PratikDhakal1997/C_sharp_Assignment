//Author: Pratik Dhakal. C0899291

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
     class Swapping
    {
        static void Main()
        {
            Console.WriteLine("Enter X:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Y:");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Before swapping: x: {0}; y: {1};", x, y);

            //swapping
            int tempVal = x;
            x= y;
            y = tempVal;

            Console.WriteLine("After swapping: x: {0}; y: {1};", x, y);

        }
    }
}
