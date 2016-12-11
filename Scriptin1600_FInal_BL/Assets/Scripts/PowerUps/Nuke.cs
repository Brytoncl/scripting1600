using UnityEngine;
using System.Collections;
using System;

public class Nuke : MonoBehaviour, IPowerUps {

	public static Action DropNuke;
		
	public void OnTriggerEnter (){
		this.gameObject.SetActive (false);
		Statics.score += 400;
		DropNuke ();
		print ("Nuke");
	}

	public void Start () {

		Enemies.SpawnPowerUp +=	NukeHandler;
	}


	public void  NukeHandler(Transform enemyPos, int randomPP){
		if (randomPP == 3) {
			this.transform.position = enemyPos.position;
			this.gameObject.SetActive (true);
		}
	}

}
