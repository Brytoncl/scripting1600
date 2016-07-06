using UnityEngine;
using System.Collections;

public class ScopeAssignment1 : MonoBehaviour {
	public int apples = 10;

	public int EatApples () {
		return apples -= 1;
	}
}
