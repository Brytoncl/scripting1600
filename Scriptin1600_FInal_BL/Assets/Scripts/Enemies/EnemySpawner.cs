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
		public int ActiveEnemies = 0;
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
				SpawnState ();
			}
			break;
		case WaveState.Waiting:
			StartCoroutine (TooEasy ());
			break;
		}
	}

	IEnumerator TooEasy (){
		yield return new WaitForSeconds (myEnemyWaves.TemporaryDificulty);
		if (myEnemyWaves.ActiveEnemies == myEnemyWaves.EnemiesLeft && state != WaveState.Spawning) {
			myEnemyWaves.EnemiesLeft += 2;
			state = WaveState.Spawning;
			SpawnState();
		}
	}

	IEnumerator WaitForSpawnDelay () {
		yield return new WaitForSeconds (myEnemyWaves.SpawnDelay);
			SpawnAnEnemy ();
			SpawnState ();

	}

	void SpawnAnEnemyButton(){
		if (Input.GetKeyDown (KeyCode.K)) {
			SpawnAnEnemy ();
			print ("incoming enemy");
		}
	}

	void SpawnAnEnemy(){
		EnemyPrefabClone [0] = Instantiate (EnemyPrefab, spawnLocations [Random.Range (1, 8)].transform.position, Quaternion.Euler (0, 0, 0)) as GameObject;
		myEnemyWaves.ActiveEnemies += 1;
		//fix set active issue;
	}

	void Start () {
		//have a start up time to get ready.
		SpawnState ();
	}
	void Update () {
		SpawnAnEnemyButton ();
	}
}
