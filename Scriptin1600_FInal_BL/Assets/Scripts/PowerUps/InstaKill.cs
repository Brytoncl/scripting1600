using UnityEngine;
using System.Collections;
using System;

public class InstaKill : PowerUps, IPowerUps {

	public int newHealth = 1;
	public int activeTime = 3;
	public int defaultHealth = 100;

	private Collider BoxCol;
	private Renderer BoxRend;

	public void OnTriggerEnter () {
		PowerUps.ActivateInstaKill (newHealth);
		SetHealth ();
		BoxCol.enabled = false;
		BoxRend.enabled = false;
		print ("InstaKill");

	}
		
	public void Start () {
		BoxCol = GetComponent<BoxCollider> ();
		BoxRend = GetComponent<Renderer> ();
		Enemies.SpawnPowerUp +=	InstaKillHandler;
	}


	public void  InstaKillHandler(Transform enemyPos, int randomPP){
		if (randomPP == 1) {
			this.transform.position = enemyPos.position;
			BoxCol.enabled = true;
			BoxRend.enabled = false;
		}
	}



}
