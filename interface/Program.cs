//Interface
using ielectric;
using iengine;
using produk_ielectric;
using ielectricengine;

public class Program{
	static void Main() {
		ElectricEngine electric = new();
		
		IEngine engine = electric;
		IElectric electrics = electric;
		IElectricEngine engineElectric = electric;
	}
}
