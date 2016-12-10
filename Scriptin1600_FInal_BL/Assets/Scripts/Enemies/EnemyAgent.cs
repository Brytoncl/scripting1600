using UnityEngine;
using System.Collections;

public class EnemyAgent : MonoBehaviour {

	//used to set destination of the nav mesh agent for the AI

	private NavMeshAgent agent;
	public GameObject player;

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		agent.destination = player.gameObject.transform.position;
	}
}
