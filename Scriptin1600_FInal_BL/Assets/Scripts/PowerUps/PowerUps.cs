using UnityEngine;
using System.Collections;
using System;

public class PowerUps : MonoBehaviour {
	//parent that gives function on collision enter, and ability()

	// interface these functions into the parent.

	public bool instaKill = false;

	public static Action <int> ActivateInstaKill;

//	void OnCollisonEnter () {
//		Ability ();
//	}
//
//	public void Ability () {
//
//	}

//	void Start  (){
//		this.gameObject.SetActive (false);
//	}

	IEnumerator InstaKillTime () 
	{
		yield return new WaitForSeconds (Statics.instaKillActiveTime);
		PowerUps.ActivateInstaKill (Statics.enemyMaxHealth);
		print ("instakill over");
		print ("success");
	}




	public void SetHealth () {
		StartCoroutine (InstaKillTime ());
	}
}
