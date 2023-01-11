namespace Animals.Model;

public abstract class Canis : Animal
{
	protected Canis(string name) : base(name)
	{
	}
	
	public virtual void WiggleTail()
	{
		Console.WriteLine($"{Name}: <wiggling tail>");
	}
}