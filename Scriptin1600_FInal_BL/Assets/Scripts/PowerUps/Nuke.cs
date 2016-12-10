using UnityEngine;
using System.Collections;
using System;

public class Nuke : MonoBehaviour {

	public static Action DropNuke;
		
	void OnTriggerEnter (){
		this.gameObject.SetActive (false);
		Statics.score += 400;
		DropNuke ();
		print ("Nuke");
	}

}
