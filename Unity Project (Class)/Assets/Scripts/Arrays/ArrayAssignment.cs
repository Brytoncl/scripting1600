using UnityEngine;
using System.Collections;

public class ArrayAssignment : MonoBehaviour {

	public int [] IntArray = new int[5];

	public string [] StringArray;

	public float [] FloatArray;

	void Function () {
		IntArray [1] += IntArray [2];
		print ("IntArray[1]=" + IntArray [1]);
	}



	void Start () {
		print ("IntArray[1]=" + IntArray [1]);
		IntArray [0] = 15;
		IntArray [3] = 37;
		StringArray [2] = "Bob";
		FloatArray [1] = 7.5f;
		Function ();
		for (int i = 0; i < StringArray.Length; i++) {
			print ("String" + i + "Is Named" + StringArray [i]);
		}
	}
}
