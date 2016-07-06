using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
	//created a public health variable viewable in the inspector
	public int health = 1;
	//any time health reaches 0 print game over in console
	void Update () 
	{
		if (health <= 0)
		{
			health = 0;
			print ("Game Over The Aliens Caught You Out Of Ammo");
		}
	}
}
