using hewan;
using parent;

public class Program
{
	static void Main() {
		Cat kucing = new Cat("cibi");
		kucing.Meow();
		
		Fish fish = new Fish();
		fish.Swim();
		
		Animal animal = new Animal("kucing");
		animal.Eat();
	}
}