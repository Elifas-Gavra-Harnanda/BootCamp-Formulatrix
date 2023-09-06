//Interface Seggregation Principle
public interface IPlayer
{
	string GetName(); //default : public 
	int GetID();
}
public interface IOnline
{
	string GetUsername();
	string GetPassword();
}
public class KarambolPlayer : IPlayer 
{
	public string GetName() {
		return "name";
	}
	public int GetID() {
		return 2;
	}
}
public class MobileLegendPlayer : IPlayer, IOnline 
{
	public string GetName() {
		return "name";
	}
	public int GetID() {
		return 2;
	}
	public string GetUsername() {
		return "username";
	}
	public string GetPassword() {
		return "pass";
	}
}