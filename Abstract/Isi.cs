using smartphone;
namespace produk;

public class Isi : Identity
{
	
	public override void NamaHp(String seri)
	{
		Console.WriteLine( "brand hp adalah " + seri);
	}
	
	public override void CameraHp(int pixel)
	{
		Console.WriteLine("Pixel camera adalah " + pixel);
	}

    public override void MemoryHp(int ram)
    {
		Console.WriteLine("RAM nya adalah " + ram);
    }
}
