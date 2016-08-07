using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class WeaponsList : MonoBehaviour {
	
	public Text WeaponPrimary;
	public Text WeaponSecondary;
	public Text WeaponStats;
	public Text WeaponStats2;

		public List<Weapons> myWeapons = new List<Weapons>();

		public void UpdateWeaponType (){
		WeaponPrimary.text = "WEAPON: " + myWeapons [0].gameObject.name.ToString ();
		WeaponSecondary.text = "SECONDARY: " + myWeapons [1].gameObject.name.ToString ();
		WeaponStats.text = "Ammo: " + myWeapons [0].magazine.ToString ();
		WeaponStats2.text = "Reserves: " + myWeapons [0].reserveAmmo.ToString ();
		}



		void Update () {
		if (Input.GetKeyUp (KeyCode.E) && myWeapons.Count >= 1) {
			myWeapons [0].gameObject.SetActive (true);
			myWeapons.RemoveAt (0);
			UpdateWeaponType ();

		}
	}
		//IEnumerator
		public void Reload (){
		if (Input.GetKeyDown (KeyCode.R)&& myWeapons [0].magazine != myWeapons [0].magazineSize && myWeapons [0].reserveAmmo > myWeapons [0].magazineSize) {
				//yield return new WaitForSeconds (reloadTime); 
			int _a = myWeapons [0].magazineSize - myWeapons [0].magazine;
			myWeapons [0].reserveAmmo -= _a;
			myWeapons [0].magazine = myWeapons [0].magazineSize;
			UpdateWeaponType ();
				print ("Weapon Loaded");
			}

		}
	

}
