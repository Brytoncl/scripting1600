using UnityEngine;
using System.Collections;

public class syntax : MonoBehaviour {
	int myInt;

	int MyInt (int _i, int _j) {
		return _i + _j;
	}

	int MyIntBy2 (int _i, int _j) {
		int _k = (_i + _j) *2;
		return _k;
	}
	void Start () {
		myInt = MyInt (10, 4);
		print (myInt);
		myInt = MyIntBy2 (10, 4);
		print (myInt);	
	}
}