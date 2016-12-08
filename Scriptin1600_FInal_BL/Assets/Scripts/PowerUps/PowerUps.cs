using UnityEngine;
using System.Collections;

public class PowerUps : MonoBehaviour {
	//parent that gives function on collision enter, and ability()

	// interface these functions into the controlls.

	void OnCollisonEnter () {
		Ability ();
	}

	public void Ability () {

	}

	void Start  (){
		this.gameObject.SetActive (false);
	}


}
