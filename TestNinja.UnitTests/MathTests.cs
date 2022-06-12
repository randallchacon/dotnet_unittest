﻿using NUnit.Framework;
using System.Linq;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        //SetUp and Tear Down
        private Math _math;

        [SetUp]
        public void SetUp() 
        { 
            _math = new Math();
        }

        [Test]
        [Ignore("Because I wanted to!")] //Para no borrar o comentar un test que necesito ignorar
        public void Add_WhenCalled_ReturnTheSumOfArguments() 
        { 
            //var math = new Math();
            var result = _math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)] //Parametrización de prueba
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult) 
        { 
            var result = _math.Max(a, b);
            Assert.That(_math.Max(a, b), Is.EqualTo(expectedResult));
        }

        /*
        [Test]
        public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument() 
        {
            //var math = new Math();
            var result = _math.Max(2, 1);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
        {
            //var math = new Math();
            var result = _math.Max(1, 2);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
        {
            //var math = new Math();
            var result = _math.Max(1, 1);
            Assert.That(result, Is.EqualTo(1));
        }
        */

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit() //Números impares
        {
            var result = _math.GetOddNumbers(5);

            //General
            //Assert.That(result, Is.Not.Empty);
            //Assert.That(result.Count(), Is.EqualTo(3));

            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));

            Assert.That(result, Is.EquivalentTo(new [] { 1, 3, 5 }));

            //Assert.That(result, Is.Ordered);
            //Assert.That(result, Is.Unique);

        }
    }
}
