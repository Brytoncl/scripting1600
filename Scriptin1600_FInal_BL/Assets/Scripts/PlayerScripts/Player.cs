using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	public Text countHealth;

	public int health;

	public int score = 0;

	public Text countScore;
	public PowerUpsList myPowerUpsList;

	public void OnTriggerEnter (Collider col) {
		myPowerUpsList.UsePowerUp ();
		}

	public void UpdateHealth () {
		countHealth.text = "HEALTH: "+ health.ToString ();
	}
	public void UpdateScore () { 
		countScore.text = "SCORE: "+ score.ToString ();
	}
	void Start () {
		UpdateScore ();
		UpdateHealth ();
	}

}
