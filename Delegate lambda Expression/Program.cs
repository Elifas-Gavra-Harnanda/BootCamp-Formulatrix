//Anonymous Delegate / Lambda Expression
void Main()
{
	Func<int, int, int> myInt0 = (int a, int b) => a + b;
	Console.WriteLine(myInt0.Invoke(3, 4));
	
	Func<int, int, int> myInt = (int a, int b) =>
	{
		int c = a + b;
		return c;
	};
	Console.WriteLine(myInt.Invoke(3,5));
	
	Func<string> myFuncPrint = () => "Hellooo"+"World";
	Func<string> myFuncPrint2 = () => "!";
	Func<string> result = myFuncPrint + myFuncPrint2;
	
	Delegate[] dels = result.GetInvocationList();
	
	foreach(Func<string> x in dels) {
		Console.WriteLine(x.Invoke());
	}
	
	result = result - myFuncPrint2;
	dels = result.GetInvocationList();
	
	foreach (Func<string> x in dels)
	{
		Console.WriteLine(x.Invoke());
	}
	
	Action<string> myAction = (string x) => Console.WriteLine(x);
	myAction.Invoke("hello");
	
	Action myAction2 = () => Console.WriteLine("Hello");
	myAction2.Invoke();
}

