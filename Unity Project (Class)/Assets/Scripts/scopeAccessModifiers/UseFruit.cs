using UnityEngine;
using System.Collections;

public class UseFruit : MonoBehaviour {
	public Fruit MyFruit;

	void Start () {
		MyFruit = new Fruit ();
		MyFruit.AddOranges (5);
		MyFruit.AddApples (10);
		MyFruit.AddApples (10);
		MyFruit.grapes = 5;

		int allFruit = MyFruit.MixFruit ();
	
			print (allFruit);
	}
}