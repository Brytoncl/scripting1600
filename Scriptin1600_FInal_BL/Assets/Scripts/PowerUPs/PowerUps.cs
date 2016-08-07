using UnityEngine;
using System.Collections;

public class PowerUps : MonoBehaviour {

	public Enemy myEnemies;
	public WeaponsList myWeaponsList;
	public Player myPlayerStats;
	public PowerUpsList myPowerUpsList;
	public int health;
	public int damage;
	public int _i;
	public GameObject [] PowerUpsArray;
	 
	void Awake () {
		PowerUpsArray = GameObject.FindGameObjectsWithTag ("PowerUps");
	}

	void OnMouseUp () {
		if (myPowerUpsList.PowerUpList.Count < 1) {
			myPowerUpsList.PowerUpList.Add (this);
			gameObject.SetActive (false);
			myPowerUpsList.powerUpNumber += _i;
		} else
			print ("Power Up Inventory Full");
	}
	public void MaxHealth() {
		myPlayerStats.health = 100;
		print ("Max Health");
		myPowerUpsList.powerUpNumber = 0;
		myPowerUpsList.PowerUpList.RemoveAt (0);
	}

	public void MaxAmmo () {
		print ("MaxAmmo");
		switch (myWeaponsList.myWeapons.Count) {

		case 2:
			myWeaponsList.myWeapons [0].reserveAmmo = myWeaponsList.myWeapons [0].maxReserves;
			myWeaponsList.myWeapons [1].reserveAmmo = myWeaponsList.myWeapons [1].maxReserves;
			myPowerUpsList.powerUpNumber = 0;
			myPowerUpsList.PowerUpList.RemoveAt (0);
			break;
		case 1:
			myWeaponsList.myWeapons [0].reserveAmmo = myWeaponsList.myWeapons [0].maxReserves;
			myPowerUpsList.powerUpNumber = 0;
			myPowerUpsList.PowerUpList.RemoveAt (0);
			break;
		default:
			print ("No Weapons In Inventory");
			break;
		}

	}

	public void Damage () {
		print ("InstaKill");
		myPowerUpsList.powerUpNumber = 0;
		myPowerUpsList.PowerUpList.RemoveAt (0);
	}

	public void Demolition () {
		print ("NUKE");
		myEnemies.NUKE ();
		myPowerUpsList.powerUpNumber = 0;
		myPowerUpsList.PowerUpList.RemoveAt (0);
	}
}
