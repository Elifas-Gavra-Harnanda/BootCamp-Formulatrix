//object box unbox
public class Progam{
static void Main()
{
	int x = 32;
	object y = x; //boxing
	
	int z = (int)y; //unboxing

	int f = 33;
	object g = f;
	long l = (int)g;
	Console.WriteLine(l);
}
}
