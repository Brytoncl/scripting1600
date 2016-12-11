using UnityEngine;
using System.Collections;
using System;

public class Enemies : HUD {

	public int damage = 50;
	public int storedHealth = 100;
	public int health = 100;
	int randomPP;
	bool canAttack = true;
	public float atttackSpeed = 1;
	public Transform enemyPos;

	public static Action <Transform, int> SpawnPowerUp;

	void InstaKillHandler (int newHealth) {
		health = newHealth;
	}

	void NukeHandler () {
		KillEnemy ();
	}

	public override void UpdateHUD ()
	{
		scoreText.text = "SCORE: " + Statics.score;
		ammoText.text = "Ammo: " + Statics.ActiveMagazine;
		reservesText.text = "reserves: " + Statics.ActiveReserves;
		healthText.text = "Health: " + Statics.playerHealth;
	}
	IEnumerator AttackDelay()
	{
		yield return new WaitForSeconds (atttackSpeed);
		canAttack = true;
	}

	IEnumerator regenertateHealth()
	{
		yield return new WaitForSeconds (3);
		while (Statics.playerHealth < 100) {
			Statics.playerHealth += 10;
			UpdateHUD ();
			yield return new WaitForSeconds (Statics.HealthRegenSpeed);
		}
		//should equal maxplayer health incase I add juggernaut later.
	}



	public void KillEnemy () {
		randomPP = UnityEngine.Random.Range (1, 100);
		SpawnPowerUp (enemyPos, randomPP);
		health = Statics.enemyMaxHealth;
		canAttack = true;
		UpdateHUD ();
		if (Statics.activeEnemies > 0) {
			Statics.activeEnemies -= 1;
		}
		this.gameObject.SetActive (false);
	}

	void OnMouseDown () {
		if (health > Statics.ActiveWeaponDamage && Statics.ActiveMagazine > 0 && Statics.canShoot == true) {
			health -= Statics.ActiveWeaponDamage;
			Statics.ActiveMagazine -= 1;
			Statics.score += 10;
			UpdateHUD ();
			print (health);
		} else if (health <= Statics.ActiveWeaponDamage && Statics.ActiveMagazine > 0 && Statics.canShoot == true) {
			print ("kill enemy");
			health -= Statics.ActiveWeaponDamage;
			KillEnemy ();
			Statics.ActiveMagazine -= 1;
			Statics.score += 10;
			Statics.score += 100;
			UpdateHUD ();
			print (health);
		}
	}

	void OnTriggerEnter () {
		if (Statics.playerHealth > 50 && canAttack) {
			Statics.playerHealth -= 50;
				canAttack = false;
			UpdateHUD ();
			StartCoroutine (AttackDelay ());
			StartCoroutine (regenertateHealth());
		}
		else if (Statics.playerHealth <=50 && canAttack){
			Statics.playerHealth = 0;
			UpdateHUD ();
			//GAME OVER
		} 
	}
		
	void OnDisable () {
		print (this.gameObject + "Disabled");
	}

	void Start () {
		Nuke.DropNuke += NukeHandler;
		InstaKill.ActivateInstaKill += InstaKillHandler;
	}
}
