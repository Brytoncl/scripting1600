using UnityEngine;
using System.Collections;

public class AlienTypes : MonoBehaviour
{
	// create an array of aliens
	public int[] alienhealth;

	// keep aliens health at 0 when they are killed and print when the aliens are killed
	public void AlienReport ()
	{
		
		if (alienhealth [0] <= 0) 
		{
			alienhealth [0] = 0;
			print ("you killed an alien");
		}
		if (alienhealth [1] <= 0) 
		{
			alienhealth [1] = 0;
			print ("you killed an alien");
		}
		if (alienhealth [2] <= 0) 
		{
			alienhealth [2] = 0;
			print ("you killed an alien");
		}
	}
}
