using UnityEngine;
using System.Collections;
using System;

public class MaxAmmo : HUD {

	public static Action AddAmmo;

	void OnTriggerEnter () {
		AddAmmo ();
		UpdateHUD();
	}
}
