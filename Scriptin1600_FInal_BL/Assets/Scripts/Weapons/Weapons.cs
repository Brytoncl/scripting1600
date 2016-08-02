using UnityEngine;
using System.Collections;

	public class Weapons : MonoBehaviour {

		public WeaponsList myWeaponsList;

		//the game object name 
		public int firePower;
		public int ammoCount;

		void OnMouseUp () {
			if (myWeaponsList.myWeapons.Count < 2) {
				myWeaponsList.myWeapons.Add (this);
				gameObject.SetActive (false);
			} else
				print ("Weapon Inventory Full");
		}
	}
