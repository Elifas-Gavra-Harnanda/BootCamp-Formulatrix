namespace produk_iengine;
using iengine;

public class PistonEngine : IEngine {
	public void EngineRun() {
		Console.WriteLine("Piston");
	}
}
public class DieselEngine : IEngine {
	public void EngineRun() {
		Console.WriteLine("Diesel");
	}
}

public class Jet : IEngine
{
	public void EngineRun() {
		Console.WriteLine("Electric");
	}
}