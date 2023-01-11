namespace Animals.Model;

public class Bird : Animal
{
	public Bird(string name) : base(name)
	{
	}
	
	public override void MakeSomeNoise()
	{
		Console.WriteLine($"{Name}: Chirp!");
	}
}