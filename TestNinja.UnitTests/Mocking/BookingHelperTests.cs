using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class BookingHelper_OverLappingBookingsExistTests
    {
        [Test]
        public void BookingStartsAndFinishesBeforeAnExistingBooking_ReturnEmptyString()
        {
            var repository = new Mock<IBookingRepository>();
            repository.Setup(r => r.GetActiveBookings(1)).Returns(new List<Booking> 
            { 
                new Booking
                {
                    Id = 1,
                    ArrivalDate = new DateTime(2022,1,15,14,0,0),
                    DepartureDate = new DateTime(2022,2,1,10,10,0),
                    Reference = "a"
                }
            }.AsQueryable());

            var result = BookingHelper.OverlappingBookingsExist(new Booking
            {
                Id = 1,
                ArrivalDate = new DateTime(2022, 1, 15, 14, 0, 0),
                DepartureDate = new DateTime(2022, 2, 1, 10, 10, 0),
                Reference = "a"
            }, repository.Object);

            Assert.That(result, Is.Empty);
        }
    }
}
