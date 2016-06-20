using UnityEngine;
using System.Collections;

public class Fruit : MonoBehaviour {

	private int apples;
	private int oranges;
	public int grapes;

	public void AddApples (int _moreApples) {
		apples += _moreApples;
	}

	public void AddOranges (int _moreOranges) {
		oranges += _moreOranges;
	
	}
	public int MixFruit () {
		return apples + oranges + grapes;
	}

	private void EatFruit () {
		apples = 0;
		oranges = 0;
		grapes = 0;
	}
}
