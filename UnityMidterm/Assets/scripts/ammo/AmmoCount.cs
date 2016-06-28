using UnityEngine;
using System.Collections;

public class AmmoCount : MonoBehaviour {

	public int magazineSize;
	public int reserveAmmo;

	int ReduceReserves () {
		return reserveAmmo -= 5;
	}

	void Reload () {
		if (reserveAmmo >= 5) {
			magazineSize = 5;
			print ("FullMagazine");
		}
		else {
			print ("Out of Ammo");
		}
	}

	void ShootGun () {
		magazineSize --;
	}

	while(magazineSize <= 0) {
		magazineSize = 0;
		print ("reload");
	} 
		else {
			print (magazineSize);
			print (reserveAmmo);
		}

		while(reserveAmmo <= 0) {
			reserveAmmo = 0;
		}
	void Update () {


		if (Input.GetKeyUp (KeyCode.Space)) {
			ShootGun ();
		}
		if (Input.GetKeyUp (KeyCode.R)) {
			Reload ();
			ReduceReserves ();
		}
	}

}