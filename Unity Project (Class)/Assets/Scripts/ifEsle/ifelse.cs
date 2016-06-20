using UnityEngine;
using System.Collections;

public class ifelse : MonoBehaviour {


	public int myInt = 1;
	public string myString;
	const string myConst = "OU812";
		
	// Use this for initialization
	void Start () {


		/*if (myBool) {
			print ("open the gates");
		} else {
			print ("close the gates");
		}*/
		if (myInt >= 1)
			print (myInt);
		else
			print (false);
	}
	
	// Update is called once per frame
	void Update () {
		
		if (myString == "Dog")
			print (myString);
		else
			print (false);

		if (myString == myConst)
			print ("Thats correct, you have now unlocked Health Powerups");

		
	
	}
}
