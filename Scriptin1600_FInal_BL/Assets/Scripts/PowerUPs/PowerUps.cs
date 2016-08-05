using UnityEngine;
using System.Collections;

public class PowerUps : MonoBehaviour {



	public int activeTime = 7;
	public int power;

	public PowerUpsList myPowerUpsList;

	void OnMouseUp () {
		if (myPowerUpsList.myPowerUps.Count < 1) {
			myPowerUpsList.myPowerUps.Add (this);
			gameObject.SetActive (false);

		}
	}
}
