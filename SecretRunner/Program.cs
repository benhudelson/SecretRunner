using CodeSample;
using System;


namespace SecretRunner
{
    class Program
    {
        static void Main(string[] args)
        {
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
            while (number < 4 || number > (Int32.MaxValue/2))
            {
                number = GetNumberFromConsole();
            }

            var isAdditive = Sample.IsSecretAdditiveForPrimeNumberPairsLessThan(number);

            Console.WriteLine("Secret(int number) is additive for all prime pairs less than {0}: {1}", number,
                isAdditive);
        }

        private static void SupplyInstructions()
        {
            Console.Clear();
            Console.WriteLine("Usage: Check to see if Secret() is additive for a given number.");
            Console.WriteLine("Please supply an Int32 number greater than 3 and less than 1,073,741,824:");
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