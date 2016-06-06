using UnityEngine;
using System.Collections;

public class ifelse : MonoBehaviour {


	public int myInt = 1;
		
	// Use this for initialization
	void Start () {


		/*if (myBool) {
			print ("open the gates");
		} else {
			print ("close the gates");
		}*/
	}
	
	// Update is called once per frame
	void Update () {
		
		if (myInt >= 1)
			print (myInt);
		else
			print (false);
		
	
	}
}
