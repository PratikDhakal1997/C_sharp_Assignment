//Author: Pratik-C0899291, 20th March, 2024.

using System;

// define an enumeration for account types, checking or savings
public enum AccountType
{
    Checking,
    Savings
}

/// <summary>
/// class representing a Bank account, can be either checking or savings,
/// allows depositing, withdrawing and check balance.
/// </summary>
public class BankAccount
{
    // properties
    /// <summary>account number, unique identifier.</summary>
    public string AccountNumber { get; private set; }

    /// <summary>balance of the account.</summary>
    public decimal Balance { get; private set; }

    /// <summary>type of the account.</summary>
    public AccountType Type { get; private set; }

    // constructors
    /// <summary>
    /// Default constructor, creates a checking account.
    /// </summary>
    public BankAccount() : this(AccountType.Checking) { }

    /// <summary>
    /// constructor to create an account of specific type.
    /// </summary>
    /// <param name="type">account type.</param>
    public BankAccount(AccountType type)
    {
        AccountNumber = GenerateAccountNumber(); // generate random account number
        Balance = 0; // initial balance is 0
        Type = type; // set account type
    }

    // methods for transactions
    /// <summary>
    /// deposit amount into account.
    /// </summary>
    /// <param name="amount">amount to deposit.</param>
    public void Deposit(decimal amount)
    {
        Balance += amount; // add to balance
        Console.WriteLine($"deposited {amount:C} into account {AccountNumber}. new balance: {Balance:C}");
    }

    /// <summary>
    /// withdraw amount from the account.
    /// </summary>
    /// <param name="amount">amount to withdraw.</param>
    public void Withdraw(decimal amount)
    {
        if (Balance >= amount) // check for enough balance
        {
            Balance -= amount; // subtract from balance
            LogTransaction($"Withdrawn {amount:C} from account {AccountNumber}. New balance: {Balance:C}");
        }
        else
        {
            LogTransaction("Insufficient funds for withdrawal.");
        }
    }


    /// <summary>
    /// check amount in the account.
    /// </summary>
    public void CheckBalance()
    {
        Console.WriteLine($"Your current balance in account {AccountNumber} is: {Balance:C}");
    }

    /// <summary>
    /// a 
    /// </summary>
    /// <param name="message">message to be logged (printed) when transaction is made</param>
    private void LogTransaction(string message)
    {
        Console.WriteLine(message);
    }

    // overloaded methods with description
    /// <summary>
    /// deposit with description.
    /// </summary>
    /// <param name="amount">amount.</param>
    /// <param name="description">transaction description.</param>
    public void Deposit(decimal amount, string description)
    {
        Deposit(amount); // do deposit
        Console.WriteLine($"description: {description}");
    }

    /// <summary>
    /// withdraw with a description.
    /// </summary>
    /// <param name="amount">amount.</param>
    /// <param name="description">description of the transaction.</param>
    public void Withdraw(decimal amount, string description)
    {
        Withdraw(amount); // do withdrawal
        Console.WriteLine($"description: {description}");
    }

    // helper method to generate account number
    /// <summary>
    /// generates a unique account number.
    /// </summary>
    /// <returns>account number as string.</returns>
    private string GenerateAccountNumber()
    {
        Random rnd = new Random();
        return rnd.Next(100000000, 999999999).ToString();
    }
}


public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Bank!");

        string accountChoice;
        BankAccount account = null;

        do
        {
            // Prompt the user to choose an account type
            Console.WriteLine("Do you want to open a Checking or Savings account?");
            Console.Write("Enter 'C' for Checking or 'S' for Savings: ");
            accountChoice = Console.ReadLine().ToUpper();

            // Validate user input
            if (accountChoice != "C" && accountChoice != "S")
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

        } while (accountChoice != "C" && accountChoice != "S");

        // Create the corresponding account based on user input
        switch (accountChoice)
        {
            case "C":
                account = new BankAccount(); //using default constructor
                Console.WriteLine($"You have opened a new {account.Type} account with number {account.AccountNumber}");
                break;
            case "S":
                account = new BankAccount(AccountType.Savings);
                Console.WriteLine($"You have opened a new {account.Type} account with number {account.AccountNumber}");
                break;
            default:
                return;
        }

        // Perform transactions based on user input
        string transactionChoice;
        do
        {
            // Prompt the user to choose a transaction
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice (1, 2, 3, or 4): ");
            transactionChoice = Console.ReadLine();

            switch (transactionChoice)
            {
                case "1":
                    Console.Write("Enter the amount to deposit: ");
                    decimal depositAmount;
                    if (decimal.TryParse(Console.ReadLine(), out depositAmount))
                    {
                        Console.Write("Do you want to add a description? ('y' for yes): ");
                        string addDescription = Console.ReadLine().ToLower();
                        if (addDescription == "y")
                        {
                            Console.Write("Enter transaction description: ");
                            string description = Console.ReadLine();
                            account.Deposit(depositAmount, description);
                        }
                        else
                        {
                            account.Deposit(depositAmount);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount. Please try again.");
                    }
                    break;
                case "2":
                    Console.Write("Enter the amount to withdraw: ");
                    decimal withdrawAmount;
                    if (decimal.TryParse(Console.ReadLine(), out withdrawAmount))
                    {
                        Console.Write("Do you want to add a description? ('y' for yes): ");
                        string addDescription = Console.ReadLine().ToLower();
                        if (addDescription == "y")
                        {
                            Console.Write("Enter transaction description: ");
                            string description = Console.ReadLine();
                            account.Withdraw(withdrawAmount, description);
                        }
                        else
                        {
                            account.Withdraw(withdrawAmount);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount. Please try again.");
                    }
                    break;
                case "3":
                    account.CheckBalance();
                    break;
                case "4":
                    Console.WriteLine("Exiting the system. Thank you for using our bank!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        } while (transactionChoice != "4");
    }
}

