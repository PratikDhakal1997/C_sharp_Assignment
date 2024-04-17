using System;
namespace Post
{
    /// <summary>
    /// Class representing a letter.
    /// </summary>
    class Lettre : Mail
    {
        // Attributes
        private string format; // Format of the letter ("A3" or "A4")

        /// <summary>
        /// Constructor for creating a new letter object.
        /// </summary>
        /// <param name="weight">Weight of the letter in grams.</param>
        /// <param name="shippingMethod">Shipping method: true for express, false for normal.</param>
        /// <param name="destinationAddress">Destination address of the letter.</param>
        /// <param name="format">Format of the letter ("A3" or "A4").</param>
        public Lettre(double weight, bool shippingMethod, string destinationAddress, string format)
            : base(weight, shippingMethod, destinationAddress)
        {
            this.format = format;
        }

        /// <summary>
        ///  method to get the format of letter.
        /// </summary>
        /// <returns>format of letter</returns>
        public string GetFormat()
        {
            return format;
        }

        /// <summary>
        /// Method to calculate the stamp amount for the letter.
        /// </summary>
        /// <returns>The stamp amount required for the letter.</returns>
        public override double stamp()
        {
            double baseFare = (format == "A4") ? 2.50 : 3.50;
            double amount = baseFare + weight / 1000.0; // Convert grams to kilograms
            if (shippingMethod)
                amount *= 2; // Double the amount for express shipping
            return amount;
        }
    }
}
