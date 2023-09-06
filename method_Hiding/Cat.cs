namespace hewan;
using animal;

public class Cat : Animal
{
	public string race = "anggora";
	public override void MakeSound() 
	{
		Console.WriteLine("Meow");
	}
	public void Jump() 
	{
		Console.WriteLine("Jump..");
	}
	public new void Eat() //recommended : new, kalau ga ya gapapa
	{
		Console.WriteLine("Cat Eat");
	}

}
