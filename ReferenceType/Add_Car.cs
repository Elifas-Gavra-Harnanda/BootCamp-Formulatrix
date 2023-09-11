namespace Add_Car;
using Car;

public class AddCar{
	public static void Add (Car car1) //reference/address
	{ 
		car1.name = "Honda";
		Console.WriteLine(car1.name); // output : Honda
	}
}
