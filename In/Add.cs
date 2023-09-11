namespace In;

public class AddData
{
	public static void Add (in int x) //pass by reference 
	{ 
		int Add = x + 3; //bisa karena masuk variable baru, not change 'x'
		Console.WriteLine(Add);
		//x = 1; //in is readonly
		Console.WriteLine(x); // output : 3
	}
}
