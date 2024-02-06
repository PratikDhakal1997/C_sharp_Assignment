//Author: Pratik Dhakal. C0899291

using System;

namespace AssignmentOne
{
    class RoseBlanches
    {
        static void Main()
        {
            Console.WriteLine("How much did you receive money ($)?");
            if (double.TryParse(Console.ReadLine(), out double totalMoney))
            {
                // calculating three-quarters of the total money for books and supplies
                double booksAndSupplies = 0.75 * totalMoney;

                // Calculating the remaining money 
                double remainingMoney = totalMoney - booksAndSupplies;

                //remaning money evenly distributed between coffee, suscription and subway.
                double evenlyDistributedMoney = remainingMoney / 3.00;

                // calculating number of coffee that can be bought
                int coffees = (int)(evenlyDistributedMoney / 2);

                // calculating number of subscription that can be bought
                int flashComputerNumbers = (int)(evenlyDistributedMoney / 4);

                //// calculating number of subway ticket that can be bought
                int subwayTickets = (int)(evenlyDistributedMoney / 3);

                // Calculating the remaining money for white roses
                double remainingForRoses = totalMoney - (booksAndSupplies + coffees * 2 + flashComputerNumbers * 4 + subwayTickets * 3);

                Console.WriteLine("Book and Supplies: {0}$", booksAndSupplies);
                Console.WriteLine("You can then buy:");
                Console.WriteLine("{0} coffees", coffees);
                Console.WriteLine("{0} Flash Computer Numbers", flashComputerNumbers);
                Console.WriteLine("{0} subway Tickets", subwayTickets);
                Console.WriteLine("and you will have ${0} for the white roses.", remainingForRoses);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid amount in dollars.");
            }
        }
    }
}
