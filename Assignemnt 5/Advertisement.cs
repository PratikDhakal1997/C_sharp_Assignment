using System;
namespace Post
{
    /// <summary>
    /// Class representing an advertisement.
    /// </summary>
    class Advertisement : Mail
    {
        /// <summary>
        /// Constructor for creating a new advertisement object.
        /// </summary>
        /// <param name="weight">Weight of the advertisement in grams.</param>
        /// <param name="shippingMethod">Shipping method: true for express, false for normal.</param>
        /// <param name="destinationAddress">Destination address of the advertisement.</param>
        public Advertisement(double weight, bool shippingMethod, string destinationAddress)
            : base(weight, shippingMethod, destinationAddress)
        {
        }

        /// <summary>
        /// Method to calculate the stamp amount for the advertisement.
        /// </summary>
        /// <returns>The stamp amount required for the advertisement.</returns>
        public override double stamp()
        {
            double amount = 5.0 * weight / 1000.0; // Convert grams to kilograms
            if (shippingMethod)
                amount *= 2; // Double the amount for express shipping
            return amount;
        }
    }
}
