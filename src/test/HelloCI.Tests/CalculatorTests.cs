using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloCI.Core;
using NUnit.Framework;

namespace HelloCI.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void ShouldAddTwoNumbers()
        {
            // Arrange
            var calc = new Calculator();

            // Act
            var sum = calc.Add(12, 34);

            // Assert
            Assert.That(sum, Is.EqualTo(46));
        }

        [Test]
        public void ShouldSubtractTwoNumbers()
        {
            // Arrange
            var calc = new Calculator();

            // Act
            var result = calc.Subtract(12, 34);

            // Assert
            Assert.That(result, Is.EqualTo(-22));
        }

        [Test]
        public void ShouldMultiplyTwoNumbers()
        {
            // Arrange
            var calc = new Calculator();

            // Act
            var result = calc.Multiply(12, 34);

            // Assert
            Assert.That(result, Is.EqualTo(408));
        }
    }
}
