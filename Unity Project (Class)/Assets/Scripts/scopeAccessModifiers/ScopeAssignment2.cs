using UnityEngine;
using System.Collections;

public class ScopeAssignment2 : MonoBehaviour {

	public ScopeAssignment1 GetFunction;

	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			GetFunction.EatApples ();
		}
	}

}
