using UnityEngine;
using System.Collections;

public class Enemies : MonoBehaviour {

	public int damage;
	public int storedHealth = 100;
	public int health = 100;
	//public FireAction fireAction;

	void OnMouseDown () {
		if ( health >  Statics.ActiveWeaponDamage && Statics.ActiveMagazine > 0 ) {
		health -= Statics.ActiveWeaponDamage;
			Statics.ActiveMagazine -= 1;

		print (Statics.ActiveMagazine);
		print (health);
		}
	}

}
