using UnityEngine;
using System.Collections;

public class PowerUps : MonoBehaviour {

	public PowerUpsList myPowerUpsList;

	public int activeTime = 7;
	public int power;

	void OnMouseUp () {
		if (myPowerUpsList.myPowerUps.Count < 1) {
			myPowerUpsList.myPowerUps.Add (this);
			gameObject.SetActive (false);
		} else
			print ("PowerUps Inventory Full");
	}
}
