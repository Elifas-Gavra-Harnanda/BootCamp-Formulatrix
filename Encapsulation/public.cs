namespace encap;

void Main()
{
	Car car = new Car("toyota");
	//car.brand.Dump(); //due to its protection level
	car.GetBrand();
}

class Car { //default : internal
	private string _brand; //default : private
	public Car(string brand) {
		_brand = brand;
	}
	public string GetBrand() { //default : private
		return _brand;
	}
}
