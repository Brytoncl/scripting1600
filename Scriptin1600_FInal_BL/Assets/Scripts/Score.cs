using UnityEngine;
using System.Collections;


public class Score : MonoBehaviour {

	public void IncreaseScore (int score, int addPoints ) {
		Statics.score += addPoints;
	}

	public void decreaseScore (int score, int price) {
		Statics.score -= price;
	}
}
