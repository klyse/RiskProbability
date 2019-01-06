using NUnit.Framework;

namespace RiskProbability.Domain.Test
{
	[TestFixture]
	public class ProbabilityTest
	{
		[Test]
		[TestCase(1,1,ExpectedResult = 0.41667)]
		public double CheckProbability_ReturnsProbability(int attacker, int defender)
		{
			return Probability.GetProbability(attacker, defender);
		}
	}
}