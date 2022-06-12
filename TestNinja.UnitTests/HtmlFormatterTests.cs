using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test] //Caso de prueba con cadenas de string
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement() 
        {
            var formatter = new HtmlFormatter();
            var result = formatter.FormatAsBold("abc");

            //Specific Assert
            Assert.That(result, Is.EqualTo("<strong>abc</strong>"));

            //More general
            Assert.That(result, Does.StartWith("<strong>").IgnoreCase); //Por defecto los assert para string son case sensitive

            //Little be more general
            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("abc"));
        }
    }
}
