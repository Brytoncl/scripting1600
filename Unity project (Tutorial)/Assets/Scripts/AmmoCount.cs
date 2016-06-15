using UnityEngine;
using System.Collections;

public class AmmoCount : MonoBehaviour {

	public int magazineSize = 31;
	public int reserveAmmo = 605;

	int ReduceReserves () {
		return reserveAmmo -= 31;
	}

	void Reload () {
		if (reserveAmmo >= 31) {
			magazineSize = 31;
			print ("FullMagazine");
		}
		else {
			print ("Out of Ammo");
		}
			}

	void ShootGun () {
		magazineSize --;
	}

	void Update () {

		if (magazineSize <= 0) {
			magazineSize = 0;
			print ("reload");
		} 
		else {
			print (magazineSize);
			print (reserveAmmo);
		}
			
		if (reserveAmmo <= 0) {
			reserveAmmo = 0;

		}
		if (Input.GetKeyUp (KeyCode.Space)) {
			ShootGun ();
		}
		if (Input.GetKeyUp (KeyCode.R)) {
			Reload ();
			ReduceReserves ();
		}
	}

}
