using UnityEngine;
using System.Collections;
using System;

public class FireAction : MonoBehaviour {

	public Action<int> FireThis;

	enum Weapon {colt, kar98k,  m1Thompson, m1Grand, DoubleBarrellShotgun }

	Weapon currentWeapon = Weapon.colt;

	void Start () {
		weaponChange ();
	}

	void weaponChange () {
		switch (currentWeapon) {
		case Weapon.colt:
			FireThis = FireColt;
			break;
		case Weapon.kar98k:
			FireThis = FireKar98K;
			break;
		case Weapon.DoubleBarrellShotgun:
			FireThis = FireShotgun;
			break;
		case Weapon.m1Grand:
			FireThis = FireM1Grand;
			break;
		case Weapon.m1Thompson:
			FireThis = FireM1Thompson;
			break;
		}
	}

	public void Fire(int health) {
		FireThis (health);
	}

	public void FireColt(int health) {
		Colt myColt;
		myColt = new Colt ();
		health -= myColt.damage;
		print(health);

	}

	public void FireKar98K(int health) {

	}

	public void FireShotgun(int health){

	}

	public void FireM1Grand(int health) {

	}
	public void FireM1Thompson(int health) {

	}
		
}
