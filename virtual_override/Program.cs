using hewan;
using animal;

public class Program
{
	static void Main()
	{
		Animal animal = new();
		animal.MakeSound();
		Cat cat = new();
		cat.MakeSound();
		Ant ant = new();
		ant.MakeSound();
	}	
}