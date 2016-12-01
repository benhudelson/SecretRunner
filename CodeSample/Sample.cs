using System;
using System.Linq;


namespace CodeSample
{
    public static class Sample
    {
        public static bool IsSecretAdditiveForPrimeNumberPairsLessThan(int number)
        {
            if (number < 4)
            {
                throw new ArgumentOutOfRangeException("Valid input must be 4 or greater");
            }
            if(number > Int32.MaxValue / 2)
            {
                throw new ArgumentOutOfRangeException("Valid input must less than 1,073,741,824");
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

        private static bool IsAdditiveForXAndY(int x, int y)
        {
            return HasSecretMethod.Secret(x + y) == HasSecretMethod.Secret(x) + HasSecretMethod.Secret(y);
        }

    }
}