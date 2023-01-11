namespace Animals.Model;

public class Wolf : Canis
{
	public Wolf(string name, int aggressiveness) : base(name)
	{
		Aggressiveness = aggressiveness;
	}
	
	public int Aggressiveness { get; }

	public override void MakeSomeNoise()
	{
		Console.WriteLine($"{Name}: Awoooo!");
	}
}