using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	int playerHealth = 200;
	int healthBoost = 5;

	int IncreaseHealth (int _a, int _b) {
		return _a + _b;
	}

	int HealthBoostSlow (int _c,int _d) {
		return (_c / _d);
	}
	void Update () {
		//healthBoost = HealthBoostSlow (healthBoost,2);
		playerHealth = IncreaseHealth (playerHealth, healthBoost);
		print (playerHealth);
	}

}
