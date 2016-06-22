[System.Serializable]
public class HealthData {

	//this is our players base health data.
	public int health;
	public int Strenght;
	public int Speed = 20;
	private int defense = 100;
	public string username;

	public int TakeDownDefense () {
	return	defense -= 10;
	}
}
