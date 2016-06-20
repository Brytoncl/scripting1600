using UnityEngine;
using System.Collections;

public class OtherDemo : MonoBehaviour {
	public GameObject player;
	private Demo playerScript;

	// Use this for initialization
	void Start () {
		playerScript = player.GetComponent<Demo>(); 
	}
	
	// Update is called once per frame
	void Update () {
		if (playerScript.health <= 0) 
		{
			print ("Another Game Object has detected that the player has died.");
		}
	}
}
