using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enemy : MonoBehaviour {

	public Weapons weaponStats;
	public WeaponsList myWeaponsList;
	public GameObject [] EnemiesArray;
	public Player myPlayerStats;

	public int i =0;
	public int activeEnemies;
	public int enemyHealth = 100;
	public bool ShouldContinue = false;

	public void NUKE() 
	{
		foreach (GameObject item in EnemiesArray) 
		{
			gameObject.SetActive (false);
		}
	}
		public void KillEnemy () 
	{
			if (enemyHealth <= 0) 
		{
			gameObject.SetActive (false);
			myPlayerStats.score += 100;
			myPlayerStats.UpdateScore ();
		}
	}
	public void Spawner (){
		bool ShouldContinue = false;

		do {
			EnemiesArray[i].gameObject.SetActive(true);
			i = Random.Range (1,20);
		} while(ShouldContinue == true);
	}

	void Awake () 
	{
		EnemiesArray = GameObject.FindGameObjectsWithTag ("Enemy");
		foreach (GameObject item in EnemiesArray) {
			gameObject.SetActive (false); 

		}
	}

	void OnMouseDown () 
	{
		if (enemyHealth > 0 && myWeaponsList.myWeapons.Count > 0 && myWeaponsList.myWeapons [0].magazine > 0 && myWeaponsList.WeaponStats.text != ("Ammo: Reloading...")) 
		{
			myWeaponsList.myWeapons [0].magazine -=1;
			enemyHealth -= myWeaponsList.myWeapons [0].firePower;
			myPlayerStats.score += 10;
			myPlayerStats.UpdateScore ();
			myWeaponsList.UpdateWeaponType ();
			KillEnemy ();
			print ("Magazine " + myWeaponsList.myWeapons [0].magazine);
		}
	}
	void Update () {
		while (activeEnemies < 20) {
			ShouldContinue = true;
		}
	}
}