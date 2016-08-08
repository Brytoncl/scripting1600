﻿using UnityEngine;
using System.Collections;

	public class Weapons : MonoBehaviour {

		public WeaponsList myWeaponsList;

		//the game object name 
		public int firePower;
		public int magazine;
		public float reloadTime; 
		public int reserveAmmo;
		public int magazineSize;
		public int maxReserves;
		public int defaultFirePower;
		int _i;
	public GameObject [] WeaponsArray;

	/*public void DamageBoost () 
	{
		foreach (GameObject item in WeaponsArray) 
		{
		}
	}
	public void DefaultDamage ()
	{
		for(int i =0; i < WeaponsArray.Length; i++)
		{
		}
	}*/

	void Awake () {
		WeaponsArray = GameObject.FindGameObjectsWithTag ("Weapon");
	}
		
		void OnMouseUp () {
			if (myWeaponsList.myWeapons.Count < 2) {
				myWeaponsList.myWeapons.Add (this);
				gameObject.SetActive (false);
				myWeaponsList.UpdateWeaponType ();
			print ("You Picked Up The "+ gameObject.name);
			} else
				print ("Weapon Inventory Full");
		}
}