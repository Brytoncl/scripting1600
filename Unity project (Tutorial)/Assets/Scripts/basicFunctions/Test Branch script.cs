using UnityEngine;
using System.Collections;

public class TestBranchscript : MonoBehaviour {

	int _i = 5;

	int My_iby2(int _i){
		return (_i *2);
	}
		
	// Use this for initialization
	void Start () {
		My_iby2 (_i);
		print (_i);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
