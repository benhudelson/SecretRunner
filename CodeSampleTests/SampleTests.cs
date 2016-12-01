using CodeSample;
using NUnit.Framework;
using System;

namespace CodeSampleTests
{
    [TestFixture]
    class SampleTests
    {
        [TestCase(504, false)]
        [TestCase(1000, false)]
        [TestCase(1000000, false)]
        public void IsSecretAdditiveForPrimeNumbersLessThan_NumberGreaterThan503_ReturnFalse(int number, bool expected)
        {
            var result = Sample.IsSecretAdditiveForPrimeNumberPairsLessThan(number);
            Assert.AreEqual(expected, result);
        }

        [TestCase(4, true)]
        [TestCase(5, true)]
        [TestCase(19, true)]
        [TestCase(306, true)]
        [TestCase(503, true)]
        public void IsSecretAdditiveForPrimeNumbersLessThan_NumberBetween5And503Inclusive_ReturnTrue(int number, bool expected)
        {
            var result = Sample.IsSecretAdditiveForPrimeNumberPairsLessThan(number);
            Assert.AreEqual(expected, result);
        }

        [TestCase(Int32.MinValue)]
        [TestCase(-1000)]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase((Int32.MaxValue/2 + 1))]
        [TestCase((Int32.MaxValue))]
        public void IsSecretAdditiveForPrimeNumbersLessThan_NumberLessThan5_ThrowsArgumentOutOfRangeException(int number)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Sample.IsSecretAdditiveForPrimeNumberPairsLessThan(number));
        }
    }
}