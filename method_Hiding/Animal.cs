namespace animal;

public class Animal
{
	public string name = "hewan";
	public int age = 2;
	public virtual void MakeSound() 
	{
		Console.WriteLine("Animal Makesound");
	}
	public void Eat() 
	{
		Console.WriteLine("Animal Eat");
	}
}

