using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enemy : MonoBehaviour {

	public Weapons weaponStats;
	public WeaponsList myWeaponsList;

	public int enemyHealth = 100;

	void OnMouseDown () {
		if (enemyHealth > 0 && myWeaponsList.myWeapons.Count > 0 && myWeaponsList.myWeapons [0].ammoCount > 0) {
			myWeaponsList.myWeapons [0].ammoCount--;
			enemyHealth -= myWeaponsList.myWeapons [0].firePower;
		}
			
		/*else
			gameObject.SetActive (false);
		print ("Killed An Enemy");*/
		}
	}
