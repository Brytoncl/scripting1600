using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public Weapons weaponStats;
	public WeaponsList myWeaponsList;

	public int enemyHealth = 100;

	void OnMouseDown () {
		//make into switch statement 
		if (myWeaponsList.myWeapons.Count >0 &&  myWeaponsList.myWeapons [0].ammoCount > 0) {
			myWeaponsList.myWeapons [0].ammoCount--;
			enemyHealth -= myWeaponsList.myWeapons [0].firePower;
		}
	}
}
