using UnityEngine;
using System.Collections;

public class Enemies : MonoBehaviour {

	public int damage;
	public int storedHealth = 100;
	public int health = 100;
	public FireAction fireAction;

	void OnMouseDown () {
		fireAction.Fire(health);
	}
}
