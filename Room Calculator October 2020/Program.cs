using System;

namespace Room_Calculator_October_2020
{
    class Program
    {
        static void Main()
        {
            double length, width, height;

            string response;

            Console.WriteLine("Hello! Welcome to the Room Calculator!");

            //response = GetUserInput("Would you like to calculate a room? (y/n): ");

            //response = "y";


            while (true)
            {
                length = ValidateDouble("Enter length: ");

                width = ValidateDouble("Enter width: ");

                height = ValidateDouble("Enter height: ");

                CalculateArea(length, width);

                CalculateVolume(length, width, height);

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();

                response = GetUserInput("Would you like to calculate a room? (y/n): ");

                if(response != "y")
                {
                    break;
                }
            }

            Console.WriteLine("Thanks for calculating rooms! Goodbye!");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static string GetUserInput(string input)
        {
            Console.Write(input);

            string output = Console.ReadLine().ToLower();

            return output;
        }

        private static double ValidateDouble(string input)
        {
            double output = 0;
            string userInput = GetUserInput(input);

            bool valid = false;

            while (!valid)
            {
                valid = double.TryParse(userInput, out output);

                if (output <= 0)
                {
                    valid = false;

                    Console.WriteLine("Invalid input. Try again.");
                    userInput = GetUserInput(input);
                }
            }

            return output;
        }

        private static void CalculatePerimeter(double length, double width)
        {
            double perimeter = 2 * (length + width);

            perimeter = Math.Round(perimeter, 2);

            Console.WriteLine($"Perimeter: { perimeter }");
        }

        private static void CalculateArea(double length, double width)
        {
            double area = length * width;

            area = Math.Round(area, 2);

            Console.WriteLine($"Area: { area }");
        }

        private static void CalculateVolume(double length, double width, double height)
        {
            double volume = length * width * height;

            volume = Math.Round(volume, 2);

            Console.WriteLine($"Volume: {volume}");
        }
    }
}