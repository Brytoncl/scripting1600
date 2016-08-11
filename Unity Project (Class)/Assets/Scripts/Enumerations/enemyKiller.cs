using UnityEngine;
using System.Collections;

public class enemyKiller : MonoBehaviour {
	
	void Start () {
		MyEnums.gameState = MyEnums.gameStates.Attacked;
	}

	void OnMouseUp () {
		MyEnums.gameState = MyEnums.gameStates.KillAllEnemies;
		this.gameObject.SetActive (false);
	}


}
