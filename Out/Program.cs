//Out = can unassigned variable, but out from method must be assigned
using Out;

public class Program{
	static void Main()
	{
		int x = 3;
		AddData.Add(out x);
		Console.WriteLine(x); // output : 4
	}
}


