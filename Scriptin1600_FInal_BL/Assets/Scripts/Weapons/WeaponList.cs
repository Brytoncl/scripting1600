using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WeaponList : MonoBehaviour {

	public List<SendToWeapons> WeaponsList;

	void SendThisHandler (SendToWeapons MapWeapons)
	{
		WeaponsList.Add (MapWeapons);

	}

	public void Start () {
		SendToWeapons.AddThisWeapon += SendThisHandler;

	}
}
