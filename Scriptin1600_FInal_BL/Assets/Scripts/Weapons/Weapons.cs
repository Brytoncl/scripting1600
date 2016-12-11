using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Weapons : MonoBehaviour {
	
	enum Weapon {colt, kar98k,  m1Thompson, m1Grand, DoubleBarrellShotgun }

	Weapon currentWeapon = Weapon.colt;

	public List <GameObject> WeaponSlots;

	public void AddWeapons(GameObject gun) {
		print ("running add weapons");
		if (WeaponSlots.Count < 2) {
			print (gun);
			WeaponSlots.Add (gun);
			//WeaponSlots.Reverse ();
		} else
			print("2");
			WeaponSlots.RemoveAt (0);
		WeaponSlots.Add (gun);
	}

	public void switchWeapons () {
		WeaponSlots.Reverse();
	}

//	Colt myColt;
//	Kar98k myKar98k;
//	DoubleBarrellShotgun myDoubleBarrellShotgun;
//	M1Thompson myM1Thompson;
//	M1Carbine myM1Carbine;
//
//
//
//	void Awake () {
//		myColt = new Colt();
//		myKar98k = new Kar98k ();
//		myDoubleBarrellShotgun = new DoubleBarrellShotgun ();
//		myM1Thompson = new M1Thompson();
//		myM1Carbine = new M1Carbine();
//	}

	void ChangeStatics (int weaponDamage, int magazine, int magazineSize, int reserves, int maxReserves, float reloadTime) {
		Statics.ActiveWeaponDamage = weaponDamage;
		Statics.ActiveMagazine = magazine;
		Statics.ActiveMagazineSize = magazineSize;
		Statics.ActiveReserves = reserves;
		Statics.ActiveMaxReserves = maxReserves;
		Statics.ActiveReloadTime = reloadTime;
	}

	public void weaponChange (int weaponDamage, int magazine, int magazineSize, int reserves, int maxReserves, float reloadTime) {
		switch (currentWeapon) {
		case Weapon.colt:
			ChangeStatics (weaponDamage, magazine, magazineSize, reserves, maxReserves, reloadTime);
			break;
		case Weapon.kar98k:
			ChangeStatics (weaponDamage, magazine, magazineSize, reserves, maxReserves, reloadTime);
			break;
		case Weapon.DoubleBarrellShotgun:
			ChangeStatics (weaponDamage, magazine, magazineSize, reserves, maxReserves, reloadTime);
			break;
		case Weapon.m1Grand:
			ChangeStatics (weaponDamage, magazine, magazineSize, reserves, maxReserves, reloadTime);
			break;
		case Weapon.m1Thompson:
			ChangeStatics (weaponDamage, magazine, magazineSize, reserves, maxReserves, reloadTime);
			break;
		}
	}
}

