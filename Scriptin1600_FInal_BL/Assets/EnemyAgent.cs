using UnityEngine;
using System.Collections;

public class EnemyAgent : MonoBehaviour {

	private NavMeshAgent agent;
	public Transform player;

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		agent.destination = Player.position;
	}
}
