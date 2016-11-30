using CodeSample;
using NUnit.Framework;
using System;

namespace CodeSampleTests
{
    [TestFixture]
    class HasSecretMethodTests
    {
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
            var result = HasSecretMethod.Secret(number);
            Assert.AreEqual(expected, result);
        }
    }
}