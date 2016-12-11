using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WeaponList : MonoBehaviour {

	public List<SendToWeapons> WeaponsList;

	void SendThisHandler (SendToWeapons MapWeapons)
	{
		WeaponsList.Add (MapWeapons);

	}

	public void Start () {
		SendToWeapons.AddThisWeapon += SendThisHandler;
		StartCoroutine (RestockNotify ());
	}

	//not needed
	IEnumerator RestockNotify() {

		yield return new WaitForSeconds (3);
		foreach (SendToWeapons item in WeaponsList) {
			print (item + "Foreach loop");
		}
		for (int i = 0; i < WeaponsList.Count; i++){
			print (WeaponsList[i] + "for loop");
		}
	}
}
