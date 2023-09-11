//dynamic = not safety, not recommended
//RuntimeBinderException
using Dynamic;
public class Program
{
	static void Main()
	{
		dynamic x = 3;
		x = "3";
		x = true;
		x = new Car();
		string name = x.name;
		Console.WriteLine(name);
	}
}