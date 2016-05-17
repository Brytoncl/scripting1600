using UnityEngine;
using System.Collections;

public class Demo : MonoBehaviour {
	public int health;

	void Start ()
	{
		DamagePlayer(10);
	}

	void DamagePlayer(int damage)
	{
		health -= damage;
	}
} 

