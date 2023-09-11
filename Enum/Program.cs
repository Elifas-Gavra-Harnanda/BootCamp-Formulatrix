//enum = collection of constanta
namespace main;
using Enum1;
using EnumPrinter;

public class Program{
static void Main()
{
	Planet[] planets = (Planet[])Enum.GetValues(typeof(Planet)); //Get Array of Enum
	foreach(var planet in planets) {
		Console.WriteLine($"planet : {planet.ToString()} index : {(int)planet}");
	}
	
	string[] planetsInString = Enum.GetNames(typeof(Planet)); //Get Array of String
	foreach(var p in planetsInString) {
		Console.WriteLine(p);
	}
	
	string planetx = (Planet.Merkurius & Planet.Earth).ToString();
	Console.WriteLine(planetx);
	
	printer.EnumPrinterx(Planet.Merkurius);
}
}

