using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.Unit.Tests.NUnit
{
    [TestFixture]
    public class TiranglePerimeterTests
    {
        #region ctor or Arrange
        private Assignment1 _assignment1;

        [SetUp]
        public void SetUp()
        {
            _assignment1 = new Assignment1();
        }

        #endregion

        #region Tests
        [Test]
        [TestCase(1, 2, 3, 6 )]
        [TestCase(5, 1, 1, 0)]
        [TestCase(1, 5 ,1, 0 )]
        [TestCase(1, 1, 5, 0)]
        #region ErrorTests
        //[TestCase(1, 2, 3, 5)]
        //[TestCase(5, 1, 1, 7)]
        //[TestCase(1, 5, 1, 7)]
        //[TestCase(1, 1, 5, 7)]
        #endregion
        public void TrainglePerimeter_WhenCalled_ReturnTheGreatherArgument(int a, int b, int c,int expectedResult)
        {
            #region Act
            var result = _assignment1.TrianglePerimeter(a, b, c);
            #endregion

            #region Assert
            Assert.That(result, Is.EqualTo(expectedResult));
            #endregion
        }
        #endregion
    }
}
