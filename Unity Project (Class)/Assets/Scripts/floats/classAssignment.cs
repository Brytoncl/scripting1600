using UnityEngine;
using System.Collections;

public class classAssignment : MonoBehaviour {

	float _a = 2.1f;
	float _b = 2.7f;

	float function (float f1, float f2) {
		return f1 + f2;

	}
	void Start () {
		print (function (_a, _b));
	}
}
