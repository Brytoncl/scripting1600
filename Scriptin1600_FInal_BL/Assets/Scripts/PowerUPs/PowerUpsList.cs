using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PowerUpsList : MonoBehaviour {

	public PowerUps otherPowerUps;
	public Player playerStats;
	public List<PowerUps> myPowerUps = new List<PowerUps>();
	public int PowerUpNumber;
	public GameObject[] powerUps;

	void Start () {
		powerUps = GameObject.FindGameObjectsWithTag ("PowerUps");
	}
	void UsePowerUp () {
		if (Input.GetKeyUp (KeyCode.Q) && myPowerUps.Count > 0) {
			myPowerUps.RemoveAt (0);
			switch (PowerUpNumber) {
			case 1:
				//health power up function
				playerStats.health = 100;
				PowerUpNumber = 0;
				print ("Health Restored");
				break;
			case 2:
				//damage boost power up function 
				break;
			case 3:
				//Fullammo power up function
				break;
			case 4:
				//Detonation power up function
				break;
			}
		} 
	}
	void Update () {
		UsePowerUp ();


	}
}