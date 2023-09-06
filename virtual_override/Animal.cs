namespace animal;

public class Animal
{
	public virtual void MakeSound() // untuk override jangan lupa untuk parent diberi virtual
	{
		Console.WriteLine("Animal Makesound");
	}

}
