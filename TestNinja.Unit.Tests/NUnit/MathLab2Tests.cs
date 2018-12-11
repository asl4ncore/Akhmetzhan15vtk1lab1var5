using System;
using TestNinja.Fundamentals;
using NUnit.Framework;

namespace TestNinja.Unit.Tests
{
    [TestFixture]
    public class MathLab2Tests
    {
        #region ctor or Arrange
        private Math_Lab2 _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math_Lab2();
        }

        #endregion

        #region Tests
        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        #region ErrorTests
        //[TestCase(2, 1, 1)]
        //[TestCase(1, 2, 1)]
        //[TestCase(1, 1, 2)]
        #endregion
        public void Max_WhenCalled_ReturnTheGreatherArgument(int a, int b,int expectedResult)
        {
            #region Act
            var result = _math.Max(a, b);
            #endregion

            #region Assert
            Assert.That(result, Is.EqualTo(expectedResult));
            #endregion
        }

        [Test]
        [TestCase(2, 1, 3)]
        [TestCase(1, 2, 3)]
        [TestCase(1, 1, 2)]
        #region ErrorTests
        //[TestCase(1, 1, 3)]
        //[TestCase(1, 1, -2)]
        //[TestCase(-1, -1, 2)]
        #endregion
        public void Add_WhenCalled_ReturnTheGreatherArgument(int a, int b, int expectedResult)
        {
            #region Act
            var result = _math.Add(a, b);
            #endregion

            #region Assert
            Assert.That(result, Is.EqualTo(expectedResult));
            #endregion
        }
        #endregion
    }
}
