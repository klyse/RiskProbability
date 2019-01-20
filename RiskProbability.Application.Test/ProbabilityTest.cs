using NUnit.Framework;

namespace RiskProbability.Application.Test
{
	[TestFixture]
	public class ProbabilityTest
	{
		[Test]
		[TestCase(1, 1, ExpectedResult = 0.41667)]
		[TestCase(10, 1, ExpectedResult = 0.99996)]
		[TestCase(20, 1, ExpectedResult = 1)]
		[TestCase(1, 10, ExpectedResult = 0)]
		[TestCase(1, 20, ExpectedResult = 0)]
		[TestCase(5, 5, ExpectedResult = 0.50620)]
		[TestCase(10, 10, ExpectedResult = 0.56759)]
		[TestCase(20, 20, ExpectedResult = 0.63343)]
		public double CheckProbability_ReturnsProbability(int attacker, int defender)
		{
			return Probability.GetProbability(attacker, defender);
		}
	}
}