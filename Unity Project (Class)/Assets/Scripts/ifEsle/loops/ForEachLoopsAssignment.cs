using UnityEngine;
using System.Collections;

public class ForEachLoopsAssignment : MonoBehaviour {
	int _a= 0;
	public string[] ForEachArray; 
	
	void Start () {
		foreach (string name in ForEachArray)
			print (name);
		print (_a += 1);
	}
}
