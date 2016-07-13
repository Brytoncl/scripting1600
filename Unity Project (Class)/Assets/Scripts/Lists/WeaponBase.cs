﻿using UnityEngine;
using System.Collections;

namespace ArtisanDream {
public class WeaponBase : MonoBehaviour {

		public WeaponsInventory myWeaponsInventory;

	//the game object name 
	public int firePower;
	public int ammoCount;

		void OnMouseUp () {
			if (myWeaponsInventory.myWeapons.Count < 2) {
				myWeaponsInventory.myWeapons.Add (this);
				gameObject.SetActive (false);
			} else
				print ("Invventory Full");
		}


	}
}