using RiskProbability.Application;
using static System.Int32;

namespace RiskProbability.Console
{
	public class Program
	{
		static void Main(string[] args)
		{
			System.Console.WriteLine("Hello World!");
			System.Console.Write("Attacker count: ");
			var attacker = System.Console.ReadLine();

			if (!TryParse(attacker, out var attackerCount))
			{
				System.Console.WriteLine("Attacker count input format is wrong.");
				return;
			}

			System.Console.Write("Defender count: ");

			var defender = System.Console.ReadLine();


			if (!TryParse(defender, out var defenderCount))
			{
				System.Console.WriteLine("Defender count input format is wrong.");
				return;
			}

			System.Console.WriteLine("The Attacker has a " + Probability.GetProbabilityString(attackerCount, defenderCount) + " chance to win.");

			System.Console.ReadLine();
		}
	}
}