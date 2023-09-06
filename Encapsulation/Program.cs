using encap;

class Program {
void Main()
	{
	Cat cat = new Cat("burhan",5);
	cat.GetName();
	cat.GetAge();
	
	cat.balance = 2;
	cat.balance();
	
	cat.SetBalances(2);
	}
}

class Animal { 
	protected string _name; 
	protected int _age;
	
	public int balance; //variable
	protected int balances {private get; set;} //property = variable method
	public Animal(string name, int age) {
		_name = name;
		_age = age;
	}
	public string GetName() { 
		return _name;
	}
	public int GetAge() {
		return _age;
	}
}
class Cat : Animal {
	public Cat(string name, int age) : base(name, age) {
		balances = 2;
		//Console.WriteLine(balances); get accessor private
	}
	public void SetBalances(int number) {
		balances = number;
	}
}
