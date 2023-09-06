using animal;
using cat;

public class Program{
static void Main()
{
	Animal animal2 = new Animal();
	Cat cat2 = (Cat) animal2;
	cat2.Eat();
}	
}