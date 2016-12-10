using UnityEngine;
using System.Collections;
using System;

public class Enemies : HUD {

	public int damage;
	public int storedHealth = 100;
	public int health = 100;



	void Start () {
		Nuke.DropNuke += NukeHandler;
		InstaKill.ActivateInstaKill += InstaKillHandler;
	}

//	void OnEneable () {
//		InstaKill.ActivateInstaKill += InstaKillHandler;
//	}
//
//	void OnDisable () {
//		InstaKill.ActivateInstaKill -= InstaKillHandler;
//	}

	public void KillEnemy () {
		this.gameObject.SetActive (false);
		UpdateHUD ();
		if (Statics.activeEnemies > 0) {
			Statics.activeEnemies -= 1;
		}
	}

	void OnMouseDown () {
		if ( health >  Statics.ActiveWeaponDamage && Statics.ActiveMagazine > 0 && Statics.canShoot == true) {
		health -= Statics.ActiveWeaponDamage;
			Statics.ActiveMagazine -= 1;
			Statics.score += 10;
			UpdateHUD ();
			print (health);
		}
	}


	void InstaKillHandler (int newHealth) {
			health = newHealth;
	}

	void NukeHandler () {
		KillEnemy ();
	}
}
