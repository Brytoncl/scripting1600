using UnityEngine;
using System.Collections;

public class BonusQuestion : MonoBehaviour {

	public bool canAsk = true;
	int i = 10;

	IEnumerator WaitToAnswer () {
		yield return new WaitForSeconds (10);
		Statics.Answer (Statics.yourAnswer);
	}
	IEnumerator CountDown () {
		
		while (i > 0) {
			print (i);
			yield return new WaitForSeconds (1);
			i--;

		}
	}
	public void Question () {
		if (canAsk == true) {
			canAsk = false;
			i = 10;
			print ("Whose Your Favorite Teacher? Hit Space for Anthony, hit U for Rodayne, Hit X for Marty, Hit P for Clayton. You Have 10 Seconds to answer. Dont worry there are no wrong answers.");
			StartCoroutine (CountDown ());
			StartCoroutine (WaitToAnswer ());

		}
	}
		void OnMouseDown () {
		Question();
		}
}
