using UnityEngine;
using System.Collections;

public class AlienTypes : MonoBehaviour {

	public int[] alienhealth;

	/*void Start ()n {
	 * while (alienhealth [0] <= 0) {
			alienhealth [0] = 0;
			print ("You killed Alien!");
		}
	 * } */
	private PlayerHealth playerHealth;

	void Awake () {
		playerHealth = GetComponent<PlayerHealth> ();
	}

	/*void Start () {
		WaitForSeconds (5);
		if (alienhealth [0] >0){
			playerHealth.health -= 1;
		}
	}*/
	void Update () {
		if (alienhealth [0] <= 0) {
			alienhealth [0] = 0;
			print ("You killed Alien!");
		}
		if (alienhealth [1] <= 0) {
			alienhealth [1] = 0;
			print ("You killed Alien!");
		}
		if (alienhealth [2] <= 0) {
			alienhealth [2] = 0;
			print ("You killed Alien!");
		}
	}

	}
