using UnityEngine;
using System.Collections;

public class WhileLoopAssignment : MonoBehaviour {

	public int monkeysInTheZoo = 7;

	void CatchThem () {
		while (monkeysInTheZoo < 7)
			monkeysInTheZoo ++;
		print ("You've Caught A Monkey");
	}
	void LetThemOut () {
		while (monkeysInTheZoo > 0) {
			monkeysInTheZoo--;
			print ("a Monkey Escaped");
		}
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.C)) {
			CatchThem ();
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			LetThemOut ();
		}
	}
}
