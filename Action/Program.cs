//Action
using Action;
public class program{
	public static void Main()
	{
		Action<string> action = Prints.Print;
		action += Prints.Printer;
		action.Invoke("name");
	}
}


// You can define other methods, fields, classes and namespaces here