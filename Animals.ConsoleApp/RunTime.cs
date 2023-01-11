using Animals.Model;

namespace Animals.ConsoleApp;

public static class RunTime
{
	public static void Run()
	{
		var animal = GetAnimal();
		animal.MakeSomeNoise();
	}

	private static Animal GetAnimal()
	{
		Console.Write("Enter animal type: ");
		var animalType = Console.ReadLine()?.ToLowerInvariant();

		Console.Write("Enter animal name: ");
		var animalName = Console.ReadLine() ?? throw new InvalidOperationException("Enter a valid name.");

		switch (animalType)
		{
			case "bird":
				return new Bird(animalName);
			case "doge":
				return new Doge(animalName);
			case "wolf":
				Console.Write("Enter wolf's aggressiveness: ");
				var aggressivenessString = Console.ReadLine() ?? throw new InvalidOperationException("Enter a valid value.");
				var aggressiveness = int.Parse(aggressivenessString);
				return new Wolf(animalName, aggressiveness);
			default:
				throw new ArgumentException($"Unknown animal type ({animalType}).");
		}
	}
}