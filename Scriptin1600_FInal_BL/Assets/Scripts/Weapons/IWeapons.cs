using UnityEngine;
using System.Collections;

public interface IWeapons {

	// Use this for initialization
	void Start ();

	void OnTriggerStay ();
	//if get key while in the trigger you can pick up the weapon

	void OnTriggerExit ();

	//void OnMouseDown ();
	//void StateChange ();
}
