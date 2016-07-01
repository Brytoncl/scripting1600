using UnityEngine;
using System.Collections;

public class AlienTypes : MonoBehaviour
{
	int _a;
	int _b;
	public int[] alienhealth;

	/*void Start ()n {
	 * while (alienhealth [0] <= 0) {
			alienhealth [0] = 0;
			print ("You killed Alien!");
		}
	 * } */
	private PlayerHealth playerHealth;

	void Awake () 
	{
		playerHealth = GetComponent<PlayerHealth> ();
	}

	/*void Start () {
		WaitForSeconds (5);
		if (alienhealth [0] >0){
			playerHealth.health -= 1;
		}
	}*/


	public void AlienReport ()
	{
		foreach (int _a in alienhealth) {
			if (_a <= 0) {
				print ("You Killed An Alien");
			}
			/*while (alienhealth [_b] <= 0) {
				_b = 0;
			}*/

			}
		if (alienhealth [0] <= 0) 
		{
			alienhealth [0] = 0;
		}
		if (alienhealth [1] <= 0) 
		{
			alienhealth [1] = 0;
		}
		if (alienhealth [2] <= 0) 
		{
			alienhealth [2] = 0;
		}
	}
}
