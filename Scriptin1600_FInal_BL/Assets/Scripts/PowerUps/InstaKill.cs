using UnityEngine;
using System.Collections;
using System;

public class InstaKill : PowerUps {

	public int newHealth = 1;
	public int activeTime = 3;
	public int defaultHealth = 100;

	void OnTriggerEnter () {
		PowerUps.ActivateInstaKill (newHealth);
		base.SetHealth ();
		this.gameObject.SetActive (false);
		print ("InstaKill");

	}



}
