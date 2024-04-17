//Author:Pratik-60899291, Date: 2024-04-17

using System.Collections.Generic;

namespace Post
{
    /// <summary>
    /// Class representing a mailbox.
    /// </summary>
    class Box
    {
        // Attributes
        private List<Mail> mails; // List to store mails in the box
        private int maxSize; // Maximum size of the mailbox

        /// <summary>
        /// constructor for creating a new mailbox object with a maximum size.
        /// </summary>
        /// <param name="maxSize">Maximum size of the mailbox.</param>
        public Box(int maxSize)
        {
            this.maxSize = maxSize;
            mails = new List<Mail>();
        }

        /// <summary>
        /// Method to add a mail to the mailbox.
        /// </summary>
        /// <param name="mail"> The mail to be added.</param>
        public void addMail(Mail mail)
        {
            mails.Add(mail);
        }

        /// <summary>
        /// Method to calculate the total stamp amount for all mails in the mailbox.
        /// </summary>
        /// <returns>The total stamp amount for all mails.</returns>
        public double stamp()
        {
            double totalAmount = 0;
            foreach (Mail mail in mails)
            {
                if (mail.isValid())
                {
                    totalAmount += mail.stamp();
                }
            }
            return totalAmount;
        }

        /// <summary>
        /// Method to count the number of invalid mails in the mailbox.
        /// </summary>
        /// <returns>The number of invalid mails.</returns>
        public int mailIsInvalid()
        {
            int invalidCount = 0;
            foreach (Mail mail in mails)
            {
                if (!mail.isValid())
                {
                    invalidCount++;
                }
            }
            return invalidCount;
        }

        /// <summary>
        /// Method to display the contents of the mailbox.
        /// </summary>
        public void display()
        {
          
            foreach (Mail mail in mails)
            {
                Console.WriteLine(mail.GetType().Name);
                if (!mail.isValid())
                {
                    Console.WriteLine("\t(Invalid courier)");
                }
                Console.WriteLine("\tWeight: " + mail.GetWeight() + " grams");
                Console.WriteLine("\tExpress: " + (mail.IsExpressShipping() ? "yes" : "no"));

                if (!mail.isValid())
                {
                    if (!String.IsNullOrEmpty(mail.GetDestinationAddress()))
                    {
                        Console.WriteLine("\tDestination: " + mail.GetDestinationAddress());
                        Console.WriteLine("\tPrice: 0.0");
                    }
                    else
                    {
                        Console.WriteLine("\tDestination: ");
                        Console.WriteLine("\tPrice: 0.0");
                    }
                }
                else
                {
                    Console.WriteLine("\tDestination: " + mail.GetDestinationAddress());
                    Console.WriteLine("\tPrice: $" + mail.stamp().ToString("0.0"));
                }

                if (mail is Lettre)
                {
                    Lettre lettre = (Lettre)mail;
                    Console.WriteLine("\tFormat: " + lettre.GetFormat());
                }
                else if (mail is Parcel)
                {
                    Parcel parcel = (Parcel)mail;
                    Console.WriteLine("\tVolume: " + parcel.GetVolume().ToString("0.0") + " liters");
                }

                Console.WriteLine();
            }
        }

    }
}
