//Reference Type
namespace test;
using Car;
using Add_Car;

public class Program{
	static void Main()
	{
		Car car = new Car("toyota");
		AddCar.Add(car); 
		Console.WriteLine(car.name); // output : Honda
	}
}


