//Author:Pratik-60899291, Date: 2024-04-17

using System;

namespace Post
{ /// <summary>
  /// Class representing a parcel.
  /// </summary>
    class Parcel : Mail
    {
        // Attributes
        private double volume; // Volume of the parcel in liters

        /// <summary>
        /// Constructor for creating a new parcel object.
        /// </summary>
        /// <param name="weight">Weight of the parcel in grams.</param>
        /// <param name="shippingMethod">Shipping method: true for express, false for normal.</param>
        /// <param name="destinationAddress">Destination address of the parcel.</param>
        /// <param name="volume">Volume of the parcel in liters.</param>
        public Parcel(double weight, bool shippingMethod, string destinationAddress, double volume)
            : base(weight, shippingMethod, destinationAddress)
        {
            this.volume = volume;
        }

        /// <summary>
        ///  method to get the volume of parcel.
        /// </summary>
        /// <returns>volume of parcel</returns>
        public double GetVolume()
        {
            return volume;
        }

        /// <summary>
        /// Method to calculate the stamp amount for the parcel.
        /// </summary>
        /// <returns>The stamp amount required for the parcel.</returns>
        public override double stamp()
        {
            double amount = 0.25 * volume + weight / 1000.0; // Convert grams to kilograms
            if (shippingMethod)
                amount *= 2; // Double the amount for express shipping
            return amount;
        }

        /// <summary>
        /// Method to check if the parcel is valid.
        /// </summary>
        /// <returns>True if the parcel is valid, otherwise false.</returns>
        public override bool isValid()
        {
            return base.isValid() && volume <= 50; // Check volume constraint
        }
    }
}
