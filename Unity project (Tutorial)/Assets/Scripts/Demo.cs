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
		if (health <= 0)
		{
			Debug.Log ("THe Player Has Died! health: " = health);
		}
	}
	void DamagePlayer(int damage)
	{
		health -= damage;
	}
} 

