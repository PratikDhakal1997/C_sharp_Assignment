using System;

namespace Post { 
/// <summary>
/// Abstract class representing a mail.
/// </summary>
abstract class Mail
{
    // Attributes
    protected double weight; // Weight of the mail in grams
    protected bool shippingMethod; // Shipping method: true for express, false for normal
    protected string destinationAddress; // Destination address of the mail

    /// <summary>
    /// Constructor for creating a new mail object.
    /// </summary>
    /// <param name="weight">Weight of the mail in grams.</param>
    /// <param name="shippingMethod">Shipping method: true for express, false for normal.</param>
    /// <param name="destinationAddress">Destination address of the mail.</param>
    public Mail(double weight, bool shippingMethod, string destinationAddress)
    {
        this.weight = weight;
        this.shippingMethod = shippingMethod;
        this.destinationAddress = destinationAddress;
    }

    /// <summary>
    /// Protected method to get the weight of the mail.
    /// </summary>
    /// <returns>The weight of the mail.</returns>
    public double GetWeight()
    {
        return weight;
    }

    /// <summary>
    /// Protected method to get the destination address of the mail.
    /// </summary>
    /// <returns>The destination address of the mail.</returns>
    public string GetDestinationAddress()
    {
        return destinationAddress;
    }

    /// <summary>
    /// Protected method to check if the mail is shipped via express.
    /// </summary>
    /// <returns>True if the mail is shipped via express, otherwise false.</returns>
    public bool IsExpressShipping()
    {
        return shippingMethod;
    }

    /// <summary>
    /// Abstract method to calculate the stamp amount for the mail.
    /// </summary>
    /// <returns>The stamp amount required for the mail.</returns>
    public abstract double stamp();

    /// <summary>
    /// Method to check if the mail is valid.
    /// </summary>
    /// <returns>True if the mail is valid, otherwise false.</returns>
    public virtual bool isValid()
    {
        return !string.IsNullOrEmpty(destinationAddress);
    }
}
    }
