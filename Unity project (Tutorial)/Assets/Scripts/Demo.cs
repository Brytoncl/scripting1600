using UnityEngine;
using System.Collections;

public class Demo : MonoBehaviour {
	public int health;

	void Start ()
	{
		DamagePlayer(20);
	}

	void Update()
	{
		if (health <= 0) {
			health = 0;
			Destroy (gameObject, 2.5f);
			Debug.Log ("THe Player Has Died! health: " + health);
		} 
		else if (health <= 15) 
		{
			print ("you have alot of life.");
		}
	}
	void DamagePlayer(int damage)
	{
		health -= damage;
	}
} 

