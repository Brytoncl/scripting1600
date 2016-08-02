using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PowerUpsList : MonoBehaviour {

	public PowerUps otherPowerUps;

	public List<PowerUps> myPowerUps = new List<PowerUps>();

	void UsePowerUp () {
		if (Input.GetKeyUp (KeyCode.Q) && myPowerUps.Count > 0) {
			myPowerUps.RemoveAt (0);
		}
	}

	void Update () {
		UsePowerUp ();
	}
}