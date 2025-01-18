using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            if (!double.TryParse(Console.ReadLine(), out double weight))
            {
                Console.WriteLine("Invalid input for weight. Please enter a number.");
                Console.ReadKey(); // Keep console open
                return; // End program
            }

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadKey(); // Keep console open
                return; // End program
            }

            Console.WriteLine("Please enter the package width:");
            if (!double.TryParse(Console.ReadLine(), out double width))
            {
                Console.WriteLine("Invalid input for width. Please enter a number.");
                Console.ReadKey(); // Keep console open
                return; // End program
            }

            Console.WriteLine("Please enter the package height:");
            if (!double.TryParse(Console.ReadLine(), out double height))
            {
                Console.WriteLine("Invalid input for height. Please enter a number.");
                Console.ReadKey(); // Keep console open
                return; // End program
            }

            Console.WriteLine("Please enter the package length:");
            if (!double.TryParse(Console.ReadLine(), out double length))
            {
                Console.WriteLine("Invalid input for length. Please enter a number.");
                Console.ReadKey(); // Keep console open
                return; // End program
            }

            double totalDimensions = width + height + length;

            if (totalDimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadKey();// Keep console open
                return; // End program
            }

            double quote = (width * height * length * weight) / 100;

            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));

            Console.WriteLine("Thank you!");

            Console.ReadKey(); // Keep console open until a key is pressed
        }
    }
}