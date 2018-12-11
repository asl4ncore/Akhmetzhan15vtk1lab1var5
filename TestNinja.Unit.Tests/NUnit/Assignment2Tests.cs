using System;
using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.Unit.Tests.NUnit
{
    [TestFixture]
    public class Assignment2Tests
    {
        #region ctor or Arrange
        private Assignment2 _assignment2;

        [SetUp]
        public void SetUp()
        {
            _assignment2 = new Assignment2();
        }

        #endregion

        #region Tests
        [Test]
        public void GetNumbersDivitedBy13_WhenCalled_ReturnDivitedBy13Numbers()
        {
            #region Act
            var result = _assignment2.GetNumbersDivitedBy13(40);
            #endregion

            #region Assert
            Assert.That(result, Is.Not.Empty);
            Assert.That(result.Count(), Is.EqualTo(3));
            Assert.That(result, Does.Contain(13));
            Assert.That(result, Does.Contain(26));
            Assert.That(result, Does.Contain(39));
            Assert.That(result, Is.EquivalentTo(new[] { 13, 26, 39 }));
            #endregion
        }
        #endregion
    }
}
