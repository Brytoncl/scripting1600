using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WeaponsList : MonoBehaviour {

		public List<Weapons> myWeapons = new List<Weapons>();

		void Update () {
		if (Input.GetKeyUp (KeyCode.E) && myWeapons.Count >= 1) {
			myWeapons [0].gameObject.SetActive (true);
			myWeapons.RemoveAt (0);
		}
	}
		//IEnumerator
		public void Reload (){
		if (Input.GetKeyDown (KeyCode.R)&& myWeapons [0].magazine != myWeapons [0].magazineSize && myWeapons [0].reserveAmmo > myWeapons [0].magazineSize) {
				//yield return new WaitForSeconds (reloadTime); 
			int _a = myWeapons [0].magazineSize - myWeapons [0].magazine;
			myWeapons [0].reserveAmmo -= _a;
			myWeapons [0].magazine = myWeapons [0].magazineSize;
				print ("Weapon Loaded");
			}

		}
	

}
