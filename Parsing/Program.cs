//Parsing (Parse and TryParse)
public class Program{
static void Main()
{
	string x = "321i";
	//Parsing string -> int (safety)
	bool status = int.TryParse(x, out int result); 
	Console.WriteLine(result);
	Console.WriteLine(status);
	
	//Parsing string -> int (not safety)
	int resultInt = int.Parse(x);
	Console.WriteLine(resultInt);
}
}