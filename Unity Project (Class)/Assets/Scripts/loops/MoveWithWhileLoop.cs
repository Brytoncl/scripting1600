using UnityEngine;
using System.Collections;

public class MoveWithWhileLoop : MonoBehaviour {
    public float xDistance = 10;
	public float yDistance = 10;
	public float zDistance = 0;
	Vector3 pos;

	IEnumerator MoveInX () {
		while (pos.x <= xDistance) {
			pos.x += 0.1f;
			print (pos.x);
			print ("loop");
			yield return new WaitForSeconds (0.05f);

		}
	}

	void Start () {
		StartCoroutine (MoveInX ());
		}
		
	}
