namespace produk_ielectric;
using ielectricengine;

public class ElectricEngine : IElectricEngine
{
	public void EngineRun() {
		Console.WriteLine("Electric");
	}
	public void Charge() 
	{
		Console.WriteLine("Charging...");
	}
}
