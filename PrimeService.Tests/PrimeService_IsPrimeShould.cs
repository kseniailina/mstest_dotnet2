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

			Assert.IsFalse(result, $"1 should not be prime");
		}
		
		[TestMethod]
		[Ignore]
		public void IgnoredTest()
		{
			var result = _primeService.IsPrime(1);

			Assert.IsFalse(result, $"1 should not be prime");
		}
		
		[TestMethod]
		public void ReturnFalseGivenValueOf3()
		{
			var result = _primeService.IsPrime(3);

			Assert.IsFalse(result, $"1 should not be prime");
		}
		
		[TestMethod]
		public void ReturnFalseGivenValueOf2()
		{
			var result = _primeService.IsPrime(2);

			Assert.IsFalse(result, $"1 should not be prime");
		}
	}
}
