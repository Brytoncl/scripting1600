using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {
	
	public float health;

	int _a = 1;
	int _b = 2;
	int _c = 3;

	float _i = .5f;

	public void DamagePlayer (float damage){
		health -= damage;
	}
	// Use this for initialization
	void Start () {
 
	}

	// Update is called once per frame
	void Update () {
		DamagePlayer (_i);

		if (health <= 0) {
			health = 0;
			print ("Game Over.");

		} else {
			print (health);
		}
	}
}



/*void Awake ()
void Start () 
Void Update() 
float
int 
string 
for
	while 
		return 
			foreach
				int [] Arr
				if 
				else
					public int [] arr;
					*/

