using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enemy : MonoBehaviour {

	public Weapons weaponStats;
	public WeaponsList myWeaponsList;
	public GameObject [] EnemiesArray;
	public Player myPlayerStats;
	public EnemySpawner myEnemySpawner;

	public float AttackSpeed = 2.5f;
	public int enemyHealth = 100;

	void OnTriggerEnter (Collider col){
		switch (col.tag) {
		case "Player":  
			myPlayerStats.health -= 50;
			print ("Player Damaged");
			myPlayerStats.UpdateHealth ();
			StartCoroutine ("WaitForAttackSpeed");
			break;

		}
	
	}
	public void FindEnemiesArray (){
		EnemiesArray = GameObject.FindGameObjectsWithTag ("Enemy");
	}

	IEnumerator WaitForAttackSpeed () {
		yield return new WaitForSeconds (AttackSpeed);
		print ("Attack");
		//attack again 
	}
	public void NUKE()
	{
		foreach (GameObject item in EnemiesArray) {
			item.gameObject.SetActive (false);
		}
	}
		public void KillEnemy () 
	{
			if (enemyHealth <= 0) 
		{
			gameObject.SetActive (false);
			myEnemySpawner.state = EnemySpawner.WaveState.Spawning;
			myEnemySpawner.myEnemyWaves.ActiveEnemies -= 1;
			myEnemySpawner.SpawnState ();
			myPlayerStats.score += 100;
			myPlayerStats.UpdateScore ();
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
}