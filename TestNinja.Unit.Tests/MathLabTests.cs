using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.Unit.Tests
{
    [TestClass]
    public class MathLabTests
    {
        [TestMethod]
        public void CanBeCancelledBy_MultiplicationGreaterThan10__ReturnsTrue()
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
        public void CanBeCancelledBy_MultiplicationGreaterThan10__ReturnsFalse()
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
        public void CanBeCancelledBy_MultiplicationGreaterThan10__ReturnsIsNotNull()
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
