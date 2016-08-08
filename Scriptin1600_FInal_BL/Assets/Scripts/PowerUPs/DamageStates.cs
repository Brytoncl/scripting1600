using UnityEngine;
using System.Collections;

public class DamageStates : MonoBehaviour 
{
	public Weapons myWeapons;
	public WeaponsList myWeaponList;
	public enum playerState {normalDamage, InstaKill};

	playerState CurrentState;

	public void NormalState () {
		CurrentState = playerState.normalDamage;
	}
	public void InstaKillState () {
		CurrentState = playerState.InstaKill;
	}
	/*public void WeaponCountSwitch () {
		switch (myWeaponList.myWeapons.Count) {

		case 2:
			myWeaponList.myWeapons [0].firePower = 100;
			myWeaponList.myWeapons [1].firePower = 100;
			StartCoroutine ("InstaKillTimer");
			break;
		case 1:
			myWeaponList.myWeapons [0].firePower = 100;
			break;
		default:
			print ("No Weapons In Inventory");
			break;
		}
	}*/
	public void InstaKill () 
	{
		switch (CurrentState) 
		{
		case playerState.InstaKill:
			//myWeapons.DamageBoost ();
			StartCoroutine ("InstaKillTimer");
			break;
		case playerState.normalDamage:
			break;
		}
	}

	IEnumerator InstaKillTimer ()
	{
		yield return new WaitForSeconds (30);
		NormalState ();
		//myWeapons.DefaultDamage ();
		print ("NormalDamage");
	}
}
