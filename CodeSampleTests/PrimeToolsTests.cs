using CodeSample;
using NUnit.Framework;
using System.Collections.Generic;

namespace CodeSampleTests
{
    [TestFixture]
    public class PrimeToolsTests
    {
        [TestCase(-1, false)]
        [TestCase(0, false)]
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(12, false)]
        [TestCase(73, true)]
        [TestCase(1000, false)]
        public void IsPrime_VariousInputs_ChecksThem(int number, bool expected)
        {
            var result = PrimeTools.IsPrime(number);
            Assert.AreEqual(expected, result);
        }

        private static IEnumerable<PrimesLessThanTestValue> PrimesLessThanTestValues()
        {
            return new List<PrimesLessThanTestValue>()
            {
                new PrimesLessThanTestValue(-1, new List<int>() {}),
                new PrimesLessThanTestValue(0, new List<int>() {}),
                new PrimesLessThanTestValue(1, new List<int>() {}),
                new PrimesLessThanTestValue(2, new List<int>() {}),
                new PrimesLessThanTestValue(3, new List<int>() {2}),
                new PrimesLessThanTestValue(12, new List<int>() {2, 3, 5, 7, 11}),
                new PrimesLessThanTestValue(36, new List<int>() {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31}),
            };
        }
        [Test, Sequential]
        public void PrimesLessThan_VariousInputs_ChecksThem(
            [ValueSource("PrimesLessThanTestValues")] PrimesLessThanTestValue PrimesLessThanTestValue)
        {
            var result = PrimeTools.PrimesLessThan(PrimesLessThanTestValue.Number);
            var expected = PrimesLessThanTestValue.Expected;
            CollectionAssert.AreEqual(expected, result);
        }
    }

    public class PrimesLessThanTestValue
    {
        public int Number { get; private set; }
        public List<int> Expected { get; private set; }

        public PrimesLessThanTestValue(int number, List<int> primes)
        {
            Number = number;
            Expected = primes;
        }

        private PrimesLessThanTestValue()
        {
        }
    }
}