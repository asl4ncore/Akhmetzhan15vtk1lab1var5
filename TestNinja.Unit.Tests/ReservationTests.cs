using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.Unit.Tests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            #region Arrange
            var reservation = new Reservation();
            #endregion

            #region Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });
            #endregion

            #region Assert
            Assert.IsTrue(result);
            #endregion
        }
    }
}
