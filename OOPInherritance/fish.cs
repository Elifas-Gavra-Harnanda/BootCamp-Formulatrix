namespace hewan;
using parent;

public class Fish : Animal
{
	public Fish (): base ("fish")
	{
		Console.WriteLine("Fish Created");
	}
	
	public void Swim()
	{
		Console.WriteLine("Swim");
	}
	
}
