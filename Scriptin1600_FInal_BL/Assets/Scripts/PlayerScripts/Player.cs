using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	public Text countHealth;

	public int health = 100;

	public int score = 0;

	public Text countScore;
	public PowerUpsList myPowerUpsList;
	public Weapons myWeapons;
	public PowerUps myPowerUps;
	public Transform Camera;

	public enum GameState {Playing, GameOver}
	//should be in its own gameState Script

	public GameState state = GameState.Playing;

	public void Play(){
		state = GameState.Playing;
	}
	public void GameOver ()
	{
		state = GameState.GameOver;
	}


	public void PlayState (){
		switch (state) {
		case GameState.Playing:
			GameObject.Find ("Player").SetActive (true);
			GameObject.Find ("Enemy").SetActive (true);
			foreach (GameObject item in myWeapons.WeaponsArray) {
				item.gameObject.SetActive (true);
			}
			break;
		case GameState.GameOver:
			GameObject.Find ("Player").SetActive (false);
			Camera.gameObject.SetActive (true);
			break;
		}
	}
	public void OnTriggerEnter (Collider col) {
		myPowerUpsList.UsePowerUp ();
		}

	public void UpdateHealth () {
		countHealth.text = "HEALTH: "+ health.ToString ();
	}
	public void UpdateScore () { 
		countScore.text = "SCORE: "+ score.ToString ();
	}
	void Awake () {
		state = GameState.Playing;
	}
	void Start () {
		UpdateScore ();
		UpdateHealth ();
		PlayState ();
	}

}
