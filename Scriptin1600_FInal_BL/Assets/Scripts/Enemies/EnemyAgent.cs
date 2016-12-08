﻿using UnityEngine;
using System.Collections;

public class EnemyAgent : MonoBehaviour {

	//used to set destination of the nav mesh agent for the AI

	private NavMeshAgent agent;
	public Transform player;

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
		player = GameObject.Find ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		agent.destination = player.position;
	}
}