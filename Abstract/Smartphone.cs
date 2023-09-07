namespace smartphone;
public abstract class Identity
{
	protected int imei;
	
	public void SetImei(int imei)
	{
		this.imei = imei;
		Console.WriteLine("Imei : " + imei);
	}
	public abstract void NamaHp(String seri);
	public abstract void CameraHp(int pixel);
	public abstract void MemoryHp(int ram);
}
