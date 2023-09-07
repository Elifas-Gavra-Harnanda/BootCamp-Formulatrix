using produk;
public class Program
{
	static void Main()
	{
		Isi iphone = new Isi();
		iphone.SetImei(012345);
		iphone.NamaHp("Iphone");
		iphone.CameraHp(2);
		
		Isi nokia = new();
		nokia.SetImei(54321);
		nokia.NamaHp("Nokia");
		nokia.CameraHp(3);
		
		
		
		
	}
}