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
			if (Input.GetKeyUp (KeyCode.F) && myWeapons.Count > 0 && myWeapons [0].ammoCount > 0) {
				myWeapons [0].ammoCount--;
			} else if ((Input.GetKeyUp (KeyCode.F) && myWeapons.Count >0)) { 
				myWeapons.RemoveAt (0);
			}
		}

}
