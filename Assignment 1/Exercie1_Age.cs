//Author: Pratik Dhakal. C0899291

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class Age
    {
        
        static void Main()
        {
            /*Exercise 1
        Write a program in C# that asks the user for age.
        reads the user's answer and saves it in an integer age variable; 
        calculates the year of birth of the user
        and records it in the variable; displays the year of birth as calculated.*/

            //Prompt the user to enter their age
            Console.WriteLine("provide your age:");

            // Read the input and convert it to integer
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                // Calculate the year of birth
                int currentYear = DateTime.Now.Year;    //Gives current age 
                int yearOfBirth = currentYear - age;

                // Display the year of birth
                Console.WriteLine("Your year of birth is: {0}", yearOfBirth);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age as a number.");
            }


        }
    }
}
