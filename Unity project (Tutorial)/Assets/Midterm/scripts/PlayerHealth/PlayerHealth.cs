using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public int health = 1;

	void Update () {
		if (health <= 0) {
			health = 0;
			print ("Game Over THe Aliens Caught You Out Of Ammo");
		}
	}
}
