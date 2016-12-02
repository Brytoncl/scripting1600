using UnityEngine;
using System.Collections;
using System;

public class SendToSpawner : MonoBehaviour {



	public static Action <SendToSpawner> SendThis;

	void Start () {
		if (SendThis != null) {
			SendThis (this);
			gameObject.SetActive (false);
		}
	}


}
