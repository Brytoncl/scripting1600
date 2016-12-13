using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Colt : Weapons, IWeapons {

	public int damage = 20;
	public int  magazine = 8;
	public int magazineSize = 8;
	public int reserves = 42;
	public int maxReserves = 126;
	public float reloadTime = 3.5f;

	public int weaponPrice = 500;

	public Text coltPickupText;


	public void stateChange() {
		
	}


	// Use this for initialization
	public override void Start () {
		base.Start ();
		coltPickupText.enabled = false;
		base.WeaponSlots.Add (this.gameObject);
		MaxAmmo.AddAmmo += MaxAmmoHandler;
		weaponChange (damage, magazine, magazineSize, reserves, maxReserves, reloadTime);
	}

	void OnMouseDown () {
		print ("clicked gun");
		base.AddWeapons (this.gameObject);
	}

	public void MaxAmmoHandler() {
		reserves = maxReserves;
		weaponChange (damage, magazine, magazineSize, reserves, maxReserves, reloadTime);

	}

	public void OnTriggerStay () {
		coltPickupText.enabled = true;
		coltPickupText.text = (this.gameObject + "Costs " + weaponPrice + "points.");
			//either on mouse down to pickup weapon or get key.
			//then replace primary slot with new weapon.
	}
	public void OnTriggerExit () {
		coltPickupText.enabled = false;
	}
}
