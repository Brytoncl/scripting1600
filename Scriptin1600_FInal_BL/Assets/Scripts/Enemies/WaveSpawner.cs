using UnityEngine;
using System.Collections;

public class WaveSpawner : MonoBehaviour {

	public enum SpawnState {SPAWNING, WAITING, COUNTING}

	[System.Serializable]
	public class Wave
	{
		public string name;
		public Transform enemy;
		public int count;
		public float spawnRate;
		public int delay;
	}

	public Wave[] Waves; 
	int nextWave = 0;
	public float TimeBetweenWaves = 5f;
	public float waveCountdown = 0;

	float searchCountdown = 1;

	public SpawnState state = SpawnState.COUNTING;

	void Start () {
		waveCountdown = TimeBetweenWaves;
	}

	void Update () {
		if (state == SpawnState.WAITING && EnemyIsAlive ()) {
				//begin new round
				print ("wave Completed");
				return;
			}
		if (waveCountdown <= 0 && state != SpawnState.SPAWNING)
		{
				StartCoroutine (SpawnWave (Waves [nextWave]));
			}
			else 
			{
				waveCountdown -= Time.deltaTime;
			}
		}
	bool EnemyIsAlive(){
		searchCountdown -= Time.deltaTime;
		if (searchCountdown <= 0f && GameObject.FindGameObjectsWithTag ("Enemy") == null) {
			searchCountdown = 1f;
				return true;
			}
		return false;
	}

	IEnumerator SpawnWave (Wave _wave){
		print ("Spawning Wave" + _wave.name);
		state = SpawnState.SPAWNING; 

		for (int i = 0; i < _wave.count; i++) {
			SpawnEnemy (_wave.enemy);
			yield return new WaitForSeconds( _wave.delay); 
		}

		state = SpawnState.WAITING;

		yield break;
	}
	void SpawnEnemy(Transform _enemy) {
		print ("spawningEnemy: " + _enemy.name);
		Instantiate (_enemy, transform.position, transform.rotation);

	}
}
