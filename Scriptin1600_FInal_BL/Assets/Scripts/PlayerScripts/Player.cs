using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	public Text countHealth;

	public int health;

	public int score = 0;

	public Text countScore;

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
