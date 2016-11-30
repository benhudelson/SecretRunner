using CodeSample;
using System;


namespace SecretRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Describe();
            // Test if input arguments were supplied:
            int number;
            if (args.Length == 0)
            {
                number = GetNumberFromConsole();
            }
            else
            {
                if (!Int32.TryParse(args[0], out number))
                {
                    number = GetNumberFromConsole();
                }
            }
            while (number < 4)
            {
                number = GetNumberFromConsole();
            }

            var sample = new Sample();
            var isAdditive = sample.IsSecretAdditiveForPrimeNumberPairsLessThan(number);

            Console.WriteLine("Secret(int number) is additive for all prime pairs less than {0}: {1}", number,
                isAdditive);
        }

        private static void Describe()
        {
            Console.WriteLine("SecretRunner takes a single integer input from the command line.");
            Console.WriteLine("The Secret() method is additive for all pairs of numbers whose sum is less than 1000.");
            Console.WriteLine(
                "All inputs greater than 3 and less than 504 have at least 2 primes less than itself for which each pair is less than 1000.");
            Console.WriteLine("The program will only accept valid Int32 numbers greater than 3.");
            Console.WriteLine("Try to input values less than 4.");
            Console.WriteLine("Try a value greater than 3 but less than 504. The result should be True.");
            Console.WriteLine("Try to input values less than 4.");
            Console.WriteLine("Try to input values less than 4.");
            Console.WriteLine("Try to input values less than 4.");
        }

        private static void SupplyInstructions()
        {
            Console.Clear();
            Console.WriteLine("Usage: Check to see if Secret() is Additive for a given number.");
            Console.WriteLine("Please supply an Int32 number greater than 3:");
        }

        private static int GetNumberFromConsole()
        {
            int number;
            SupplyInstructions();
            while (!Int32.TryParse(Console.ReadLine(), out number))
            {
                SupplyInstructions();
            }
            return number;
        }
    }
}