using UnityEngine;
using System.Collections;

public class Switches : MonoBehaviour {


	public enum MyOperations { ADD, SUBTRACT, MULTIPLY, DEVIDE, SQUARE };

	public MyOperations currentOperation;

	public int _a;
	public int _b;
	public string Operations;

	int ChangeOperation (int _a,int _b){
		int value = 0;
		switch (currentOperation) {
		case MyOperations.ADD:
			value = _a + _b;
			break;
		case MyOperations.SUBTRACT:
			value = _a - _b;
			break;
		case MyOperations.MULTIPLY:
			value = _a * _b;
			break;
		case MyOperations.DEVIDE:
			value = _a / _b;
			break;
		case MyOperations.SQUARE:
			value = (_a + _b) * (_a + _b);
			break;

		}
		return value;
	}

	void OnMouseDown () {
		int finalValue = ChangeOperation (_a, _b);
		print (finalValue);
	}
}