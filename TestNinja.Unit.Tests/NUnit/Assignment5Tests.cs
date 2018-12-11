using System;
using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;
using static TestNinja.Fundamentals.Assignment3;

namespace TestNinja.Unit.Tests.NUnit
{
    [TestFixture]
    public class Assignment5Tests
    {
        #region ctor or Arrange
        private Assignment5 _assignment5;

        [SetUp]
        public void SetUp()
        {
            _assignment5 = new Assignment5();
        }

        #endregion

        #region Tests
        [Test]
        [TestCase("admin", "1234")]
        [TestCase("Admin", "5678")]
        [TestCase("ADMIN", "91011")]
        public void Log_InvalidError_ThrowArgumentException(string login, string password)
        {
            #region Act
            var logger = new Assignment5();
            #endregion

            #region Assert
            Assert.That(() => logger.CreateUser(login, password), Throws.ArgumentException);
            #endregion
        }
        #endregion
    }
}
