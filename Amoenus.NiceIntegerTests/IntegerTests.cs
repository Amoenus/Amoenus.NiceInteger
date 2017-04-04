using System;
using Amoenus.NiceInteger;
using NUnit.Framework;
using Shouldly;

namespace Amoenus.NiceIntegerTests
{
    [TestFixture]
    public class IntegerTests
    {
        [Test]
        [TestCase(1, 1, true)]
        [TestCase(2, 1, true)]
        [TestCase(1, 2, false)]
        [TestCase(2, 3, false)]
        [TestCase(2, 2, true)]
        [TestCase(-1, 1, true)]
        [TestCase(-2, 1, true)]
        [TestCase(-1, 2, false)]
        [TestCase(-2, 3, false)]
        [TestCase(-2, 2, true)]
        [TestCase(1, -1, true)]
        [TestCase(2, -1, true)]
        [TestCase(1, -2, false)]
        [TestCase(2, -3, false)]
        [TestCase(2, -2, true)]
        [TestCase(0, 3, true)]
        public void IsDivisibleByTest(int divident, int devisor, bool expectedResult)
        {
            bool actualResult = divident.IsDivisibleBy(devisor);

            actualResult.ShouldBe(expectedResult,
                                  $"Testing divisibility of {divident} by {devisor}");
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 0)]
        public void IsDivisibleByTest(int divident, int devisor)
        {
            Should.Throw<DivideByZeroException>(() => divident.IsDivisibleBy(devisor));
        }

        [Test]
        [TestCase(0, true)]
        [TestCase(1, false)]
        [TestCase(2, true)]
        [TestCase(3, false)]
        [TestCase(4, true)]
        [TestCase(5, false)]
        [TestCase(-1, false)]
        [TestCase(-2, true)]
        [TestCase(-3, false)]
        [TestCase(-4, true)]
        [TestCase(-5, false)]
        public void IsEvenTest(int divident, bool expectedResult)
        {
            bool actualResult = divident.IsEven();

            actualResult.ShouldBe(expectedResult,
                                  $"Testing if {divident} is even number");
        }

        [Test]
        [TestCase(0, false)]
        [TestCase(1, true)]
        [TestCase(2, false)]
        [TestCase(3, true)]
        [TestCase(4, false)]
        [TestCase(5, true)]
        [TestCase(-1, true)]
        [TestCase(-2, false)]
        [TestCase(-3, true)]
        [TestCase(-4, false)]
        [TestCase(-5, true)]
        public void IsOddTest(int divident, bool expectedResult)
        {
            bool actualResult = divident.IsOdd();

            actualResult.ShouldBe(expectedResult,
                                  $"Testing if {divident} is odd number");
        }
    }
}