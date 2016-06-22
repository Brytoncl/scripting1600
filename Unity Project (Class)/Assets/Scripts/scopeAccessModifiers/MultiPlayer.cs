using UnityEngine;
using System.Collections;

public class MultiPlayer : MonoBehaviour {

	public HealthData[] Players;

	void Start () {
		foreach (HealthData _hd in Players) {
			print (_hd.username+ " "+_hd.health);
			int playerDefense = _hd.TakeDownDefense ();
			print (playerDefense);


		}
	}
}
