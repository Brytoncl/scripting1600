using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enemy : MonoBehaviour {

	public Weapons weaponStats;
	public WeaponsList myWeaponsList;
	public GameObject [] EnemiesArray;
	public Player myPlayerStats;
	public EnemySpawner myEnemySpawner;
	public PowerUps myPowerUps;

	public float AttackSpeed = 2.5f;
	public int enemyHealth = 100;
	public int PowerUpDropOdds = 0;
	public Transform enemyPos;

	public enum AttackState {Attacking,NotAttacking}

	AttackState state = AttackState.Attacking;

	void OnTriggerEnter (Collider col){
		switch (state) {
		case AttackState.Attacking:
			switch (col.tag) {
			case "Player":  
				if (myPlayerStats.health > 50) { 
					myPlayerStats.health -= 50;
					print ("Player Damaged");
					myPlayerStats.UpdateHealth ();
					state = AttackState.NotAttacking;
				} else {
					myPlayerStats.health = 0;
					myEnemySpawner.StopSpawning ();
					myPlayerStats.GameOver();
					myPlayerStats.PlayState ();
				}
				//this makes all enemies unable to attack 
				break;
			}
			break;
		case AttackState.NotAttacking:
			StartCoroutine (WaitForAttackSpeed());
			print ("cant attack");
			break;
		}
	}
		public void RandomPowerUp(){
		switch (PowerUpDropOdds) {
		case 1:
			myPowerUps.PowerUpsArray [0].transform.position = enemyPos.transform.position;
			myPowerUps.PowerUpsArray [0].gameObject.SetActive (true);
		break;
		case 2:
			myPowerUps.PowerUpsArray [1].transform.position = enemyPos.transform.position;
			myPowerUps.PowerUpsArray [1].gameObject.SetActive (true);
			break;
		case 3:
			myPowerUps.PowerUpsArray [2].transform.position = enemyPos.transform.position;
			myPowerUps.PowerUpsArray [2].gameObject.SetActive (true);
			break;
		case 4:
			myPowerUps.PowerUpsArray [3].transform.position = enemyPos.transform.position;
			myPowerUps.PowerUpsArray [3].gameObject.SetActive (true);
			break;
		}
	
	}
	public void FindEnemiesArray (){
		EnemiesArray = GameObject.FindGameObjectsWithTag ("Enemy");
	}

	IEnumerator WaitForAttackSpeed () {
		yield return new WaitForSeconds (AttackSpeed);
		state = AttackState.Attacking;
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
			
			myEnemySpawner.state = EnemySpawner.WaveState.Spawning;
			myEnemySpawner.myEnemyWaves.ActiveEnemies -= 1;
			myEnemySpawner.SpawnState ();
			myPlayerStats.score += 100;
			myPlayerStats.UpdateScore ();
			PowerUpDropOdds = Random.Range (1, 100);
			RandomPowerUp ();
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
}