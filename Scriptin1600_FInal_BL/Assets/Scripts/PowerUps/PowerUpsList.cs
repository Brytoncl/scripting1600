using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PowerUpsList : MonoBehaviour {

	public List<SendToPPList> WeaponsList;

	void SendThisHandler (SendToPPList MapWeapons)
	{
		WeaponsList.Add (MapWeapons);

	}

	public void Start () {
		SendToPPList.AddThisPP += SendThisHandler;

	}
}