using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class MyLists : MonoBehaviour {


	public List<string> playerNames = new List<string> (); 
	public Text myInputText;


	// Update is called once per frame
	void OnMouseUp () {
		if (myInputText.text != null) {
			playerNames.Add (myInputText.text);
		}
	}
}
