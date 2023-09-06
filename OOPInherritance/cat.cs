namespace hewan;
using parent;

public class Cat : Animal
{
	public Cat (string name): base (name)
	{
		Console.WriteLine($"cat {name} Created");
	}
	
	public void Meow()
	{
		Console.WriteLine("Meow");
	}
	
}
