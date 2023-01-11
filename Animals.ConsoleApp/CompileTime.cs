using Animals.Model;

namespace Animals.ConsoleApp;

public static class CompileTime
{
	public static void Run()
	{
		var animals = new Animal[]
		{
			new Doge("Hades"),
			new Doge("Artemis"),
			new Wolf("Zeus", aggressiveness: 42),
			new Bird("Nyx")
		};

		MakeSomeNoise(animals);

		Console.WriteLine();

		var canis = animals
			.OfType<Canis>();

		Wiggle(canis);

		static void MakeSomeNoise(IEnumerable<Animal> animals)
		{
			foreach (var animal in animals)
				animal.MakeSomeNoise();
		}

		static void Wiggle(IEnumerable<Canis> canis)
		{
			foreach (var aCanis in canis)
				aCanis.WiggleTail();
		}
	}
}