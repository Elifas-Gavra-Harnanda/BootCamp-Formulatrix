namespace Ref;

public class AddData
{
	public static void Add (ref int x) //pass by reference 
	{ 
		x++;
		Console.WriteLine(x); // output : 4
	}
}
