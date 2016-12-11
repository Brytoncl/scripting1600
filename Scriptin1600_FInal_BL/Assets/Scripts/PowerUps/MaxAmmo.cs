using UnityEngine;
using System.Collections;
using System;

public class MaxAmmo : HUD {
	
	public Transform maxAmmoPos;

	public static Action AddAmmo;

	void Start () {

		Enemies.SpawnPowerUp +=	MaxAmmoHandler;
	}


	public void  MaxAmmoHandler(Transform enemyPos, int randomPP){
		if (randomPP == 2) {
			this.transform.position = enemyPos.position;
			this.gameObject.SetActive (true);
		}
	}

	void OnTriggerEnter () {
		AddAmmo ();
		UpdateHUD();
		gameObject.SetActive (false);
	}
}
