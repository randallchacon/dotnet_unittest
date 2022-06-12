//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    //[TestClass]
    //public class ReservationTests
    //{
    //    [TestMethod]
    //    //public void CanBeCancelledBy_Scenario_ExpectedBehavior()
    //    public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
    //    {
    //        //Arrange
    //        var reservation = new Reservation();

    //        //Act  metodo que voy a probar
    //        var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

    //        //Assert prueba que el resultado sea correcto
    //        Assert.IsTrue(result);
    //    }

    //    [TestMethod]
    //    public void CanBeCancelledBy_SameUserCancellingTheReservation_True() {
    //        var user = new User();

    //        var reservation = new Reservation{ MadeBy = user};

    //        var result = reservation.CanBeCancelledBy(user);

    //        Assert.IsTrue(result);
    //    }

    //    [TestMethod]
    //    public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnFalse() {
    //        var reservation = new Reservation{ MadeBy = new User()};

    //        var result = reservation.CanBeCancelledBy(new User());

    //        Assert.IsFalse(result);
    //    }
    //}

    [TestFixture]
    public class ReservationTests
    {
        [Test]
        //public void CanBeCancelledBy_Scenario_ExpectedBehavior()
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act  metodo que voy a probar
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert prueba que el resultado sea correcto
            //3 formas distintas de hacer un assert
            //Assert.IsTrue(result);
            Assert.That(result, Is.True);
            //Assert.That(result == true);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancellingTheReservation_True()
        {
            var user = new User();

            var reservation = new Reservation { MadeBy = user };

            var result = reservation.CanBeCancelledBy(user);

            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnFalse()
        {
            var reservation = new Reservation { MadeBy = new User() };

            var result = reservation.CanBeCancelledBy(new User());

            Assert.IsFalse(result);
        }
    }
}
