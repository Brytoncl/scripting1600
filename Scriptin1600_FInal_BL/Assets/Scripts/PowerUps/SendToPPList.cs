using UnityEngine;
using System.Collections;
using System;

public class SendToPPList : MonoBehaviour {

	public static Action <SendToPPList> AddThisPP;

	void Start () {
		if (AddThisPP != null) {
			AddThisPP (this);
			this.gameObject.SetActive (false);
		}
	}
}