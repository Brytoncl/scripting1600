using UnityEngine;
using System.Collections;

public class GameStarter : MonoBehaviour {

	public GameObject myLevel;

	void ChangeGame () {
		switch (MyEnums.gameState) { 
		case MyEnums.gameStates.Starting:
			print ("Starting"); 
			myLevel.SetActive (false);
			break;

		case MyEnums.gameStates.Playing: 
			print ("Playing");
			myLevel.SetActive (true);
			this.gameObject.SetActive (false);
			break;

		case MyEnums.gameStates.Ending:
			print ("Ending");
			break;
		}
	}

	void Start () {
		ChangeGame ();
	}
	void OnMouseDown () {
		MyEnums.gameState = MyEnums.gameStates.Playing;
		ChangeGame ();
	}

}
