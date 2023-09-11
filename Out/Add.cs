namespace Out;

public class AddData
{
	public static void Add (out int x) //pass by reference 
	{ 
		x = 4; //out must be assign variable
		//x.Dump(); // output : 4
	}
}
