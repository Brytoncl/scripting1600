using UnityEngine;
using System.Collections;
using System;

public class SendToWeapons : MonoBehaviour {

	public static Action <SendToWeapons> AddThisWeapon;

	void Start () {
		if (AddThisWeapon != null) {
			AddThisWeapon (this);
		}
	}
}
