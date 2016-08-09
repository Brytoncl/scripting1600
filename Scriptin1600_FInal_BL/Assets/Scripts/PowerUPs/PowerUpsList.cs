using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PowerUpsList : MonoBehaviour 
{

	public List<PowerUps> PowerUpList = new List<PowerUps>();
	public PowerUps myPowerUps;
	public int powerUpNumber;

	public void UsePowerUp () 
	{
		if (Input.GetKeyUp (KeyCode.Q) && PowerUpList.Count > 0) 
		{
			switch (powerUpNumber) 
			{
			case 1:
				myPowerUps.MaxHealth ();
				break;
			case 2:
				myPowerUps.Demolition ();
				break;
			case 3:
				myPowerUps.Damage ();
				break;
			case 4:
				myPowerUps.MaxAmmo ();
				break;
			default:
				print ("Ability Empty");
				break;
			}
		}
	}
	void Update () 
	{
		UsePowerUp ();
	}
}