using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour {

	[System.Serializable]
	public class EnemyWaves
	{
		public int WaveNumber;
		//public int EnemiesAlive;
		public int EnemiesLeft = 20;
		public int ActiveEnemies = 1;
		public float SpawnDelay = 3;
		public int TemporaryDificulty = 10;

	}

	public enum WaveState {Spawning, Waiting,}

	public EnemyWaves[] waves;

	//public int timeBetweenWaves;
	public EnemyWaves myEnemyWaves;

	public WaveState state; 

	public Transform [] spawnLocations;
	public GameObject EnemyPrefab;
	public GameObject[] EnemyPrefabClone;

	public void SpawnState () {
		switch (state){
		case WaveState.Spawning:
			if (myEnemyWaves.ActiveEnemies != myEnemyWaves.EnemiesLeft) {
				StartCoroutine (WaitForSpawnDelay ());
			} else {
				state = WaveState.Waiting;
			}
			break;
		case WaveState.Waiting:
			StartCoroutine (TooEasy ());
			state = WaveState.Spawning;
			//SpawnState();
			break;
		}
	}

	IEnumerator TooEasy (){
		yield return new WaitForSeconds (myEnemyWaves.TemporaryDificulty);
		myEnemyWaves.EnemiesLeft += 2;
	}

	IEnumerator WaitForSpawnDelay () {
		yield return new WaitForSeconds (myEnemyWaves.SpawnDelay);
			SpawnAnEnemy ();
		//SpawnState ();

	}

	void SpawnAnEnemyButton(){
		if (Input.GetKeyDown (KeyCode.K)) {
			SpawnAnEnemy ();
			print ("incoming enemy");
		}
	}

	void SpawnAnEnemy(){
		EnemyPrefabClone[0] = Instantiate(EnemyPrefab, spawnLocations [Random.Range (1,8)].transform.position, Quaternion.Euler (0, 0, 0)) as GameObject;
		//need to make gameobject setactive
	}
	void Start () {
		SpawnState ();
	}
	void Update () {
		SpawnAnEnemyButton ();
	}
}
