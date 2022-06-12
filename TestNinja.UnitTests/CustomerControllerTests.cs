using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests //Testing return type of methods
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(0);

            //Not found
            Assert.That(result, Is.TypeOf<NotFound>()); //la más usada 

            //Not found or one of its derivates
            //Assert.That(result, Is.InstanceOf<NotFound>());
        }
    }
}
