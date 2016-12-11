using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class M1Thompson : Weapons,IWeapons {

	public int damage = 20;
	public int  magazine = 8;
	public int magazineSize = 8;
	public int reserves = 42;
	public int maxReserves = 126;
	public float reloadTime = 3.5f;

	public int weaponPrice;

	public Text thompsonPickupText;

	public void Start () {
		thompsonPickupText.enabled = false;
		MaxAmmo.AddAmmo += MaxAmmoHandler;
	}
	public void MaxAmmoHandler(){
		reserves = maxReserves;
	}

	public void OnTriggerStay (){
		thompsonPickupText.enabled = true;
		thompsonPickupText.text = (this.gameObject + "Costs " + weaponPrice + "points.");
		//either on mouse down to pickup weapon or get key.
		//then replace primary slot with new weapon.
	}

	public void OnTriggerExit () {
		thompsonPickupText.enabled = false;
	}
}
