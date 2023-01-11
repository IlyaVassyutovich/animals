namespace Animals.Model;

public class Doge : Canis
{
	public Doge(string name) : base(name)
	{
	}
	
	public override void MakeSomeNoise()
	{
		Console.WriteLine($"{Name}: Woof-woof");
	}
	
	public override void WiggleTail()
	{
		Console.WriteLine($"{Name}: <happily wiggling tail>");
	}
}