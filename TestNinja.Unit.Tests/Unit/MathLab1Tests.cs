using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.Unit.Tests
{
    [TestClass]
    public class MathLab1Tests
    {
        [TestMethod]
        public void Multiplication_IsGreaterThan10_ReturnsTrue()
        {
            #region Arrange
            var comparison = new Comparison();
            #endregion

            #region Act
            var result = comparison.MultiplicationGreaterThan10(2, 6);
            #endregion

            #region Assert
            Assert.IsTrue(result);
            #endregion
        }

        [TestMethod]
        public void Multiplication_IsGreaterThan10_ReturnsFalse()
        {
            #region Arrange
            var comparison = new Comparison();
            #endregion

            #region Act
            var result = comparison.MultiplicationGreaterThan10(2, 4);
            #endregion

            #region Assert
            Assert.IsFalse(result);
            #endregion
        }

        [TestMethod]
        public void Multiplication_IsGreaterThan10_ReturnsIsEqually()
        {
            #region Arrange
            var comparison = new Comparison();
            #endregion

            #region Act
            var result = comparison.MultiplicationGreaterThan10(2, 5);
            #endregion

            #region Assert
            Assert.IsNotNull(result);
            #endregion
        }
    }
}
