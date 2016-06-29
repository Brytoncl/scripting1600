using UnityEngine;
using System.Collections;

public class AmmoCount : MonoBehaviour {

	public int magazineSize;
	public int reserveAmmo;

	private AlienTypes alienTypes;
	private PlayerHealth playerHealth;

	void Awake () {
		alienTypes = GetComponent<AlienTypes> ();
		playerHealth = GetComponent<PlayerHealth> ();
	}

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
		if (magazineSize < 0) {
			playerHealth.health -= 1;
		}
		if (magazineSize >= 1) {
			alienTypes.alienhealth [0] -= 1;
			if (alienTypes.alienhealth [0] <= 0) {
				alienTypes.alienhealth [1] -= 1;
			}
			if (alienTypes.alienhealth [1] <= 0) {
				alienTypes.alienhealth [2] -= 1;
			}
			}
	}


	void Update () {

		if (magazineSize <= 0) {
			magazineSize = 0;
			print ("reload");
		} 
		/*else
		{
			print (magazineSize);
			print (reserveAmmo);
		}*/


		if (reserveAmmo <= 0) {
			reserveAmmo = 0;
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			ShootGun ();
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			Reload ();
			ReduceReserves ();
		}
	}

}
