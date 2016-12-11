using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Kar98k : Weapons {


	public int damage = 20;
	public int  magazine = 8;
	public int magazineSize = 8;
	public int reserves = 42;
	public int maxReserves = 126;
	public float reloadTime = 3.5f;

	public int weaponPrice = 1000;
	public Text kar98kPickUpText;

	void Start () {
		kar98kPickUpText.enabled = false;
		MaxAmmo.AddAmmo += MaxAmmoHandler;
	}
	public void MaxAmmoHandler(){
		reserves = maxReserves;
	}

	void OnTriggerStay (){
		kar98kPickUpText.enabled = true;
		kar98kPickUpText.text = (this.gameObject + "Costs " + weaponPrice + "points.");
		//either on mouse down to pickup weapon or get key.
		//then replace primary slot with new weapon.
	}

	void OnTriggerExit () {
		kar98kPickUpText.enabled = false;
	}
}
