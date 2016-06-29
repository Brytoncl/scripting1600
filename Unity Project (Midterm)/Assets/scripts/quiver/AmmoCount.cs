using UnityEngine;
using System.Collections;

public class Quiver : MonoBehaviour {

	public int magazineSize;
	public int reserveAmmo;

	int ReduceReserves () {
		return reserveAmmo -= 1;
	}

	void Reload () {
		if (reserveAmmo >= 1) {
			magazineSize = 1;
			print ("ArrowDrawn");
		}
		else {
			print ("Out of Ammo");
		}
	}

	void ShootGun () {
		magazineSize --;
	}


	while {
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
