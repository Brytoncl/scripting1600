using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public int Health;

	//links health
	//chus should attack link and take away 1 health on hit
	void Start () {
		Health = 3;
		print (Health);
	}


}
