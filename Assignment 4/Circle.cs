//Author: Pratik Dhakal, march 25, 2024

using System;

/// <summary>
/// represents a circle with a radius and a center point.
/// </summary>
class Circle
{
    private double radius;
    private double xCenter;
    private double yCenter;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="r">The radius of the circle.</param>
    /// <param name="x">The x-coordinate of the center.</param>
    /// <param name="y">The y-coordinate of the center.</param>
    public Circle(double r, double x, double y)
    {
        radius = r;
        xCenter = x;
        yCenter = y;
    }

    /// <summary>
    /// Gets the radius of the circle.
    /// </summary>
    public double Radius
    {
        get { return radius; }
    }

    /// <summary>
    /// gets the x-coordinate of the center of the circle.
    /// </summary>
    public double XCenter
    {
        get { return xCenter; }
    }

    /// <summary>
    /// get the y-coordinate of the center of the circle.
    /// </summary>
    public double YCenter
    {
        get { return yCenter; }
    }

    /// <summary>
    /// Calculates the area of the circle.
    /// </summary>
    /// <returns>the area of the circle.</returns>
    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    /// <summary>
    /// Calculates the perimeter of the circle.
    /// </summary>
    /// <returns>The perimeter of the circle.</returns>
    public double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }

    /// <summary>
    /// Checks if a point with the specified coordinates is inside the circle.
    /// </summary>
    /// <param name="x">The x-coordinate of the point.</param>
    /// <param name="y">The y-coordinate of the point.</param>
    /// <returns>ttrue if the point is inside the circle, otherwise false.</returns>
    public bool IsPointInside(double x, double y)
    {
        double distance = Math.Sqrt(Math.Pow(x - xCenter, 2) + Math.Pow(y - yCenter, 2));
        return distance <= radius;
    }

    /// <summary>
    /// Prints information about the circle (radius, center coordinates, area, and perimeter).
    /// </summary>
    public void PrintInfo()
    {
        Console.WriteLine($"Circle with radius {radius}, center ({xCenter},{yCenter})");
        Console.WriteLine($"Area: {CalculateArea()}");
        Console.WriteLine($"Perimeter: {CalculatePerimeter()}");
    }

    /// <summary>
    /// Prompts the user to enter the number of circles to create.
    /// </summary>
    /// <returns>The number of circles to create.</returns>
    public static int GetNumberOfCirclesFromUser()
    {
        int numberOfCircles;
        bool validInput = false;

        do
        {
            Console.Write("Enter the number of circles you want to create: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out numberOfCircles) && numberOfCircles > 0)
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid positive integer greater than zero.");
            }
        } while (!validInput);

        return numberOfCircles;
    }

    /// <summary>
    /// Creates an array of Circle objects based on user input.
    /// </summary>
    /// <param name="numCircles">The number of circles to create.</param>
    /// <returns>An array of Circle objects.</returns>
    public static Circle[] CreateCircles(int numCircles)
    {
        Circle[] circles = new Circle[numCircles];
        for (int i = 0; i < numCircles; i++)
        {
            Console.WriteLine($"Enter details for Circle {i + 1}:");
            double radius = GetValidRadiusInput();
            double xCenter = GetValidDoubleInput("X center");
            double yCenter = GetValidDoubleInput("Y center");

            circles[i] = new Circle(radius, xCenter, yCenter);
        }
        return circles;
    }

    /// <summary>
    /// Prompts the user to enter a point to check if it's inside each circle and validates the input.
    /// </summary>
    /// <returns>The coordinates of the point.</returns>
    public static (double, double) GetPointToCheck()
    {
        Console.WriteLine("Enter the point to check if it's inside the circle:");
        double x = GetValidDoubleInput("Enter the x-coordinate of the point to check:");
        double y = GetValidDoubleInput("Enter the y-coordinate of the point to check:");
        return (x, y);
    }

    /// <summary>
    /// Prompts the user to enter a valid double input for radius.
    /// </summary>
    /// <returns>A valid non-zero radius.</returns>
    private static double GetValidRadiusInput()
    {
        double radius;
        bool validInput = false;

        do
        {
            radius = GetValidDoubleInput("Radius");
            if (radius > 0)
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid value greater than zero.");
            }
        } while (!validInput);

        return radius;
    }

    /// <summary>
    /// Prompts the user to enter a double input and validate it.
    /// </summary>
    /// <param name="prompt">The prompt to display to the user.</param>
    /// <returns>A valid double input.</returns>
    private static double GetValidDoubleInput(string prompt)
    {
        double value;
        bool validInput = false;

        do
        {
            Console.Write($"{prompt}: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out value))
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid double.");
            }
        } while (!validInput);

        return value;
    }
}

/// <summary>
/// Entry point of the program.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        int numCircles = Circle.GetNumberOfCirclesFromUser();
        Circle[] circles = Circle.CreateCircles(numCircles);

        Console.WriteLine("\nInformation for each circle:");
        foreach (var circle in circles)
        {
            circle.PrintInfo();
            Console.WriteLine();
        }

        (double xPoint, double yPoint) = Circle.GetPointToCheck();

        Console.WriteLine("\nChecking if the point is inside each circle:");
        foreach (var circle in circles)
        {
            bool isInside = circle.IsPointInside(xPoint, yPoint);
            Console.WriteLine($"Point ({xPoint}, {yPoint}) is {(isInside ? "inside" : "outside")} the circle with center ({circle.XCenter}, {circle.YCenter}) and radius {circle.Radius}");
        }
    }
}
