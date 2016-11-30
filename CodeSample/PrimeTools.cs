using System.Collections.Generic;

namespace CodeSample
{
    public static class PrimeTools
    {
        public static IList<int> PrimesLessThan(int number)
        {
            var primes = new List<int>();
            if (number > 2)
            {
                primes.Add(2);
            }
            for (int i = 3; i < number; i = i + 2)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }
            return primes;
        }

        public static bool IsPrime(int number)
        {
            //gcd is greatest common divisor
            //lcd is least common divisor
            int gcd = number;

            if (number < 2) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            for (int lcd = 3; lcd < gcd; lcd = lcd + 2)
            {
                if (number % lcd == 0)
                {
                    return false;
                }
                //Each time the potential lcd increases, the potential gcd decreases by the ratio of number:lcd
                gcd = number / lcd;
            }
            return true;
        }

    }

}