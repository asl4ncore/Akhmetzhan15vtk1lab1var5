using System;
using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;
using static TestNinja.Fundamentals.Assignment3;

namespace TestNinja.Unit.Tests.NUnit
{
    [TestFixture]
    public class Assignment3Tests
    {
        #region ctor or Arrange
        private Assignment3 _assignment3;

        [SetUp]
        public void SetUp()
        {
            _assignment3 = new Assignment3();
        }

        #endregion

        #region Tests
        [Test]
        [TestCase(1)]
        public void DownloadFile_WhenCalled_ReturnComplete(double procent)
        {
            #region Act
            var result = _assignment3.DownloadFile(procent);

            #endregion

            #region Assert
            Assert.That(result, Is.TypeOf<Complete>());
            Assert.That(result, Is.InstanceOf<Complete>());

            #endregion
        }

        [Test]
        [TestCase(2)]
        public void DownloadFile_WhenCalled_ReturnError(double procent)
        {
            #region Act
            var result = _assignment3.DownloadFile(procent);

            #endregion

            #region Assert
            Assert.That(result, Is.TypeOf<Error>());
            Assert.That(result, Is.InstanceOf<Error>());

            #endregion
        }

        [Test]
        [TestCase(0.5)]
        public void DownloadFile_WhenCalled_ReturnStart(double procent)
        {
            #region Act
            var result = _assignment3.DownloadFile(procent);

            #endregion

            #region Assert
            Assert.That(result, Is.TypeOf<Start>());
            Assert.That(result, Is.InstanceOf<Start>());

            #endregion
        }
        #endregion
    }
}
