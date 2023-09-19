public class Program{
static void Main()
{
	Func<int,int,int> myInt = Adder;
	Console.WriteLine(myInt.Invoke(3,4));

	Func<int, int, string> myString = Printer;
	Console.WriteLine(myInt.Invoke(3, 4));
}

static int Adder(int a, int b) {
	return a+b;
}
static string Printer(int a, int b) {
	return (a+b).ToString();
}
}