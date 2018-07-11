using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestClass]
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        [TestMethod]
        public void ReturnFalseGivenValueOf1()
        {
            var result = _primeService.IsPrime(1);
            
            Console.WriteLine("some stdOut text");
            Console.Error.WriteLine("some stdErr text");

            Assert.IsFalse(result, $"1 should not be prime");
        }

        [TestMethod]
        [Ignore]
        public void IgnoredTest()
        {
            var result = _primeService.IsPrime(1);
            
            Console.WriteLine("some stdOut text");
            Console.Error.WriteLine("some stdErr text");

            Assert.IsFalse(result, $"1 should not be prime");
        }

        [TestMethod]
        public void ReturnFalseGivenValueOf3()
        {
            var result = _primeService.IsPrime(3);

            Console.WriteLine("some stdOut text");
            Console.Error.WriteLine("some stdErr text");

            Assert.IsFalse(result, $"1 should not be prime");
        }

        [TestMethod]
        public void ReturnFalseGivenValueOf2()
        {
            var result = _primeService.IsPrime(2);

            Console.WriteLine("some stdOut text");
            Console.Error.WriteLine("some stdErr text");
            
            Assert.IsFalse(result, $"1 should not be prime");
        }
    }
}