namespace parent;

public class Animal
{
	public string name;
	
	public Animal(string name)
	{
		Console.WriteLine($"animal {name} created");
	}
	
	public void Eat()
	{
		Console.WriteLine("Eat");
	}
}
