using UnityEngine;
using System.Collections;

public class Demo : MonoBehaviour {
	public int health;

	public string[] arrayString;

	void Update()
	{
		DamagePlayer (1);
		if (health <= 0)
		{
			health = 0;
			Destroy (gameObject, 2.5f);
			Debug.Log ("THe Player Has Died! health: " + health);
		} 

		print (arrayString[1]);
	}
	public void DamagePlayer(int damage)
	{
		health -= damage;
	}
} 

