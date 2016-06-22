using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public int Health;


	void Start () {
		Health = 3;
		print (Health);
	}

	void OnMouseDown () {
		Health -= 1;
		print (Health); 

	}
}

