using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enemy : MonoBehaviour {

	public Weapons weaponStats;
	public WeaponsList myWeaponsList;
	public GameObject [] EnemiesArray;

	public int enemyHealth = 100;

	public void NUKE() {
			foreach (GameObject item in EnemiesArray) {
				gameObject.SetActive (false);
			}
	}
	void Awake () {
		EnemiesArray = GameObject.FindGameObjectsWithTag ("Enemy");
	}

	void OnMouseDown () {
		if (enemyHealth > 0 && myWeaponsList.myWeapons.Count > 0 && myWeaponsList.myWeapons [0].magazine > 0) {
			myWeaponsList.myWeapons [0].magazine -=1;
			enemyHealth -= myWeaponsList.myWeapons [0].firePower;
			print ("Magazine =" + " " + myWeaponsList.myWeapons [0].magazine);
		}
	}
}