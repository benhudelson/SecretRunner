using System;
using System.Linq;


namespace CodeSample
{
    public class Sample
    {
        public int Secret(int number)
        {
            if (number < 1000)
            {
                return number;
            }
            return number + 1;
        }

        public bool IsSecretAdditiveForPrimeNumberPairsLessThan(int number)
        {
            if (number < 4)
            {
                throw new ArgumentOutOfRangeException("Valid input must be 4 or greater");
            }
            var primes = PrimeTools.PrimesLessThan(number);
            var count = primes.Count();

            for (int i = count - 1; i > 0; --i)
            {
                var x = primes[i];
                for (int j = i - 1; j >= 0; --j)
                {
                    var y = primes[j];
                    if (!IsAdditiveForXAndY(x, y))
                    {
                        return false;
                    }
                }

            }
            return true;
        }

        private bool IsAdditiveForXAndY(int x, int y)
        {
            return Secret(x + y) == Secret(x) + Secret(y);
        }
        
    }
}