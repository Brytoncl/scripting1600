using UnityEngine;
using System.Collections;

public class HealthDamage : MonoBehaviour {

	public MultiPlayer mP;

	void OnMouseDown () { 
		foreach (HealthData _hd in mP.Players) {
			if (_hd.username == this.name) {
				print (_hd.TakeDownDefense () + " " + _hd.username); 
			}
		}
	}


}
