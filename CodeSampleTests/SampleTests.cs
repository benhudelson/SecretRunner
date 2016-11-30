using CodeSample;
using NUnit.Framework;
using System;

namespace CodeSampleTests
{
    [TestFixture]
    class SampleTests
    {
        private Sample _sample = new Sample();

        [TestCase(Int32.MinValue, Int32.MinValue)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(63, 63)]
        [TestCase(967, 967)]
        [TestCase(-2, -2)]
        [TestCase(1000, 1001)]
        [TestCase(545415, 545416)]
        [TestCase(Int32.MaxValue - 1, Int32.MaxValue)]
        public void Secret_NumberLessThan1000_ReturnsNumber_And_NumberGreaterThan999_ReturnsNumberPlusOne(int number,
            int expected)
        {
            var result = _sample.Secret(number);
            Assert.AreEqual(expected, result);
        }

        [TestCase(504, false)]
        [TestCase(1000, false)]
        [TestCase(1000000, false)]
        public void IsSecretAdditiveForPrimeNumbersLessThan_NumberGreaterThan503_ReturnFalse(int number, bool expected)
        {
            var result = _sample.IsSecretAdditiveForPrimeNumberPairsLessThan(number);
            Assert.AreEqual(expected, result);
        }

        [TestCase(4, true)]
        [TestCase(5, true)]
        [TestCase(19, true)]
        [TestCase(306, true)]
        [TestCase(503, true)]
        public void IsSecretAdditiveForPrimeNumbersLessThan_NumberBetween5And503Inclusive_ReturnTrue(int number, bool expected)
        {
            var result = _sample.IsSecretAdditiveForPrimeNumberPairsLessThan(number);
            Assert.AreEqual(expected, result);
        }

        [TestCase(Int32.MinValue)]
        [TestCase(-1000)]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void IsSecretAdditiveForPrimeNumbersLessThan_NumberLessThan5_ThrowsArgumentOutOfRangeException(int number)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sample.IsSecretAdditiveForPrimeNumberPairsLessThan(number));
        }
    }
}