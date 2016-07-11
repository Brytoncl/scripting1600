using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PowerUpInventory : MonoBehaviour {

	public List<PowerUpBase> myPowerUps = new List<PowerUpBase> ();

	public void AddPowerUpToList (PowerUpBase _pub) {
		myPowerUps.Add (_pub); 
		i++;
		print (_pub.name);
	}
	public int i = -1;

	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			if (i > -1) {
				PowerUpStatics.mySpeed += myPowerUps [i].speed;
				myPowerUps.RemoveAt (i);
				i--;
				print (PowerUpStatics.mySpeed);
			}
		}
	}
}
