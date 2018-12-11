using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.Unit.Tests.NUnit
{
    [TestFixture]
    public class MathLab1Tests
    {
        #region ctor or Arrange
        private Comparison _comp;

        [SetUp]
        public void SetUp()
        {
            _comp = new Comparison();
        }

        #endregion

        [Test]
        [TestCase(2, 6, true)]
        [TestCase(2, 4, false)]
        [TestCase(2, 5, true)]
        #region ErrorTests
        //[TestCase(2, 6, false)]
        //[TestCase(2, 4, true)]
        //[TestCase(2, 5, false)]
        #endregion
        public void Max_WhenCalled_ReturnTheGreatherArgument(int a, int b, bool expectedResult)
        {
            #region Act
            var result = _comp.MultiplicationGreaterThan10(a, b);
            #endregion

            #region Assert
            Assert.That(result, Is.EqualTo(expectedResult));
            #endregion
        }
    }
}
