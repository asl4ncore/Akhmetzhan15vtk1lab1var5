using System;
using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;
using static TestNinja.Fundamentals.Assignment3;

namespace TestNinja.Unit.Tests.NUnit
{
    [TestFixture]
    public class Assignment4Tests
    {
        #region ctor or Arrange
        private Assignment4 _assignment4;

        [SetUp]
        public void SetUp()
        {
            _assignment4 = new Assignment4();
        }

        #endregion

        #region Tests
        [Test]
        public void CreateUser_IsLoginPass_ReturnIsEquaToPass()
        {
            #region Act
            var tester = new Assignment4();
            tester.CreateUser("Admin", "1234");

            #endregion

            #region Assert
            Assert.That(tester.Password, Is.EqualTo("1234"));

            #endregion
        }

        #endregion
    }
}
