using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUD : MonoBehaviour {
	public Text ammoText;
	public Text weaponText;
	public Text reservesText;
	public Text healthText;
	public Text scoreText;

	public void PrintReload ( ) {
		ammoText.text = "Reloading...";
	}

	public virtual void UpdateHUD() {
		scoreText.text = "SCORE: " + Statics.score;
		ammoText.text = "Ammo: " + Statics.ActiveMagazine;
		reservesText.text = "reserves: " + Statics.ActiveReserves;
		healthText.text = "Health: " + Statics.playerHealth;
	}
}
