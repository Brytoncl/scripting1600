using UnityEngine;
using System.Collections;

public class M1Thompson : MonoBehaviour {

	public int damage = 20;
	public int  magazine = 8;
	public int magazineSize = 8;
	public int reserves = 42;
	public int maxReserves = 126;
	public float reloadTime = 3.5f;

	void Start () {
		MaxAmmo.AddAmmo += MaxAmmoHandler;
	}
	public void MaxAmmoHandler(){
		reserves = maxReserves;
	}
}
