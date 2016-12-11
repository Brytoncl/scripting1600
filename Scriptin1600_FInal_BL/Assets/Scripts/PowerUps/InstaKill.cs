using UnityEngine;
using System.Collections;
using System;

public class InstaKill : PowerUps, IPowerUps {

	public int newHealth = 1;
	public int activeTime = 3;
	public int defaultHealth = 100;

	public void OnTriggerEnter () {
		PowerUps.ActivateInstaKill (newHealth);
		base.SetHealth ();
		this.gameObject.SetActive (false);
		print ("InstaKill");

	}

	public void Start () {

		Enemies.SpawnPowerUp +=	InstaKillHandler;
	}


	public void  InstaKillHandler(Transform enemyPos, int randomPP){
		if (randomPP == 1) {
			this.transform.position = enemyPos.position;
			this.gameObject.SetActive (true);
		}
	}



}
