using UnityEngine;
using System.Collections;

public class ForLoopAssignment : MonoBehaviour 
{

	int _a;
	public int[] BasicArray;

	void SubtractFromAll () {
		
			for (int i = 0; i < BasicArray.Length; i++) {
				BasicArray [i] -= 15;
		}
	}
	void AddToAll () {
			for (int i = 0; i < BasicArray.Length; i++) {
				BasicArray [i] += 15;
			}
	}

	void Update () 
	{
		
		if (Input.GetKeyDown (KeyCode.A)) {
			AddToAll ();
			}
		if (Input.GetKeyDown (KeyCode.B)) {
			SubtractFromAll ();
		}
	}

}