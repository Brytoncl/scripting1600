﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ZombieSpawner : MonoBehaviour {

	public Transform[] spawnPoints;
	//public GameObject[] zombies;
	public bool canSpawnZombies = true;

	int i;
	int j;


	public List<SendToSpawner> zombieRecycleList;

	void SendThisHandler (SendToSpawner _recycler)
	{
		zombieRecycleList.Add (_recycler);

	}
		
	IEnumerator SpawnZombies ()
	{
		j = 0;
		while (canSpawnZombies)
		{
			i = Random.Range(0, spawnPoints.Length - 1);
			yield return new WaitForSeconds(Statics.spawnFrequency);
			zombieRecycleList[j].transform.position = spawnPoints [i].position;
			zombieRecycleList [j].gameObject.SetActive (true);
			j++;
			if (j > zombieRecycleList.Count) {

				j = 0;
			}
		
	
	
		}
	}
	void Start () {
		StartCoroutine(SpawnZombies());
		//zombieRecycleList = new List<SendToSpawner> ();
		SendToSpawner.SendThis += SendThisHandler;
	}

	// Update is called once per frame
	void Update () {
	
	}
}
	
