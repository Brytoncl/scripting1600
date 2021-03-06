using UnityEngine;
using System.Collections;

public class AmmoCount : MonoBehaviour 
{
	//make ammo counts visible in the inspector
	public int grenade = 1;
	public int magazineSize;
	public int reserveAmmo;

	//access alientypes script
	private AlienTypes alienTypes;
	private PlayerHealth playerHealth;

	void Awake ()
	{
		alienTypes = GetComponent<AlienTypes> ();
		playerHealth = GetComponent<PlayerHealth> ();
	}

	// function to subtract form reserve ammo and add to magazine
	int ReduceReserves ()
	{
		return reserveAmmo -= 5;
	}

	//function to reload a magazine and hurt player when trying to shoot with an empty magazine
	void Reload () 
	{
		
		if (reserveAmmo >= 5)
		{
			magazineSize = 5;
			print ("FullMagazine");
		}
		else 
		{
			print ("Out of Ammo");
		}
	}
	//Function to throw a grenade that kills all aliens at once
	void ThrowGrenade () {
		grenade -= 1;
		for (int i = 0; i < alienTypes.alienhealth.Length; i++) {
			alienTypes.alienhealth [i] = 0;
		}
			
	}
	// function that reduces magzine and hurts the alien in return (needs to access alientypes script)
	void ShootGun () 
	{
	    magazineSize --;
		if (magazineSize < 0) 
		{
			playerHealth.health -= 1;
		}
		if (magazineSize >= 1) 
		{
			alienTypes.alienhealth [0] -= 1;
			if (alienTypes.alienhealth [0] <= 0) 
			{
				alienTypes.alienhealth [1] -= 1;
			}
			if (alienTypes.alienhealth [1] <= 0)
			{
				alienTypes.alienhealth [2] -= 1;
			}
		}
		alienTypes.AlienReport ();
	}

	//access functions on key down and notify when out of ammo
	void Update () {

		if (magazineSize <= 0) 
		{
			magazineSize = 0;
			print ("reload");
		} 



		if (reserveAmmo <= 0)
		{
			reserveAmmo = 0;
		}

		if (Input.GetKeyDown (KeyCode.Space))
		{
			ShootGun ();
		}
		if (Input.GetKeyDown (KeyCode.R))
		{
			Reload ();
			ReduceReserves ();
		}
		if (Input.GetKeyDown (KeyCode.G))
			ThrowGrenade ();
	}

}
