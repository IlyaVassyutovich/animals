namespace Animals.Model;

public abstract class Animal
{
	protected Animal(string name)
	{
		Name = name;
	}
	
	public string Name { get; }
	public abstract void MakeSomeNoise();
}