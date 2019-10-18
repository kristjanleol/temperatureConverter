using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int celsius = 0;
            int fahrenheit = 0;

            Loop: Console.WriteLine("Please answer 1 or 2, do you want to convert: \n1) celsius to fahrenheit. \n2) fahrenheit to celsius.");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case ("1"):
                {
                    convertCelsiusToFahrenheit(out celsius, out fahrenheit);
                        break;
                }
                case ("2"):
                {
                    convertFahrenheitToCelsius(out celsius, out fahrenheit);
                        break;
                }
                default:
                {
                    Console.WriteLine("Your input doesn't match 1 or 2, try again.\n");
                    goto Loop;
                }

            }

        }

        private static void convertFahrenheitToCelsius(out int celsius, out int fahrenheit)
        {
            Console.WriteLine("Ok, let's convert fahrenheit to celsius");
            Fahrenheit: Console.WriteLine("Please enter fahrenheit degrees (in numbers).");

                try
                {
                    fahrenheit = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a valid number!");
                    goto Fahrenheit;
                }

            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"Your degrees in celsius: {celsius}");
        }

        private static void convertCelsiusToFahrenheit(out int celsius, out int fahrenheit)
        {
            Console.WriteLine("Ok, let's convert celsius to fahrenheit");
            Celsius: Console.WriteLine("please enter celsius degrees (in numbers).");
                try
                {
                    celsius = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a valid number!");
                    goto Celsius;
                }
            fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine($"Your degrees in fahrenheit: {fahrenheit}");
        }
    }

}
