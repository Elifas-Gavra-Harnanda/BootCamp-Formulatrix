//Ref = assigned variable
using Ref;

public class Program
{
	static void Main()
	{
		int x = 3; //value type
		AddData.Add(ref x);
		Console.WriteLine(x); // output : 4
	}
}


