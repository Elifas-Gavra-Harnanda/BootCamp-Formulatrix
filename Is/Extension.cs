namespace Extension;

using System.Reflection;

using Parent;

public static class MyExtensionMethod
{
	public static void Checker(this object x) {
		if (x is Parent)  {
			Console.WriteLine("x is child of Parent");
		}
		if (x is int) {
			Console.WriteLine("value is int");
		}
		if (x is int y) { //Pattern matching ( if x is int, then assign it to y)
			Console.WriteLine(y);
		}
		if (x is ValueType) {
			Console.WriteLine("value is value type");
		}
		if (!(x is ValueType)) {
			Console.WriteLine("value is reference type");
		}
		if (x is null) {
			Console.WriteLine("value is null");
		}
		else if (x.GetType().GetTypeInfo().IsClass) {
			Console.WriteLine("value is reference type");
		}
	}
}
