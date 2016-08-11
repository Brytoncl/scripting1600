﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour {

	[System.Serializable]
	public class EnemyWaves
	{
		//public int WaveNumber;
		//public int EnemiesAlive;
		public int EnemiesLeft = 20;
		public int ActiveEnemies = 0;
		public float SpawnDelay = 3;
		public int TemporaryDificulty = 10;

	}

	public enum WaveState {Spawning, Waiting,Stop}

	public EnemyWaves[] waves;
	//public int timeBetweenWaves;
	public EnemyWaves myEnemyWaves;
	public Player myPlayer;

	public WaveState state; 

	public Transform [] spawnLocations;
	public GameObject EnemyPrefab;
	public GameObject[] EnemyPrefabClone;

	public void StopSpawning(){
		state = WaveState.Stop;
	}
	public void SpawnState () {
		switch (state){
		case WaveState.Spawning:
			if (myEnemyWaves.ActiveEnemies < myEnemyWaves.EnemiesLeft) {
				StartCoroutine (WaitForSpawnDelay ());
			} else {
				state = WaveState.Waiting;
				SpawnState ();
			}
			break;
		case WaveState.Waiting:
			StartCoroutine (TooEasy ());
			break;
		case WaveState.Stop:
			break;
		}
	}

	IEnumerator TooEasy (){
		yield return new WaitForSeconds (myEnemyWaves.TemporaryDificulty);
		if (myEnemyWaves.ActiveEnemies == myEnemyWaves.EnemiesLeft && state != WaveState.Spawning && myPlayer.state != Player.GameState.GameOver) {
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

	void SpawnAnEnemy(){
		EnemyPrefabClone [0] = Instantiate (EnemyPrefab, spawnLocations [Random.Range (1, 8)].transform.position, Quaternion.Euler (0, 0, 0)) as GameObject;
		myEnemyWaves.ActiveEnemies += 1;
		//EnemyPrefabClone [0].gameObject.SetActive (true);
	}

	void Start () {
		//have a start up time to get ready.
		SpawnState ();
	}
}
