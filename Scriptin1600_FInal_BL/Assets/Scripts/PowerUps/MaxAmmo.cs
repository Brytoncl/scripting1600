using UnityEngine;
using System.Collections;
using System;

public class MaxAmmo : HUD, IPowerUps {
	
	public Transform maxAmmoPos;

	public static Action AddAmmo;

	public void Start () {

		Enemies.SpawnPowerUp +=	MaxAmmoHandler;
	}


	public void  MaxAmmoHandler(Transform enemyPos, int randomPP){
		if (randomPP == 2) {
			this.transform.position = enemyPos.position;
			this.gameObject.SetActive (true);
		}
	}

	public void OnTriggerEnter () {
		AddAmmo ();
		UpdateHUD();
		gameObject.SetActive (false);
	}
}
