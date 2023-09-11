//In = ReadOnly
//For optimization, not allocate new memory
using In;

public class Program
{
	static void Main()
	{	
		int x = 3;
		AddData.Add(in x);
		Console.WriteLine(x); // output : 3
	}
}


