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
    public class VideoServicesTests
    {
        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            var service = new VideoService(new FakeFileReader());
            //var result = service.ReadVideoTitle(new FakeFileReader());//Dependency Injection by parameter
            //service.FileReader = new FakeFileReader();  

            var result = service.ReadVideoTitle();

            Assert.That(result, Does.Contain("error").IgnoreCase);
        }
    }
}
