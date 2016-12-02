using UnityEngine;
using System;

public class delegateClass : MonoBehaviour {


	public static Action MyEvent;
	// public delegate void MyDelegate;
	//public static event MyDelegate MyEvent;


	public static Action<string> EventWithArgs;
	//public dlegate  void MyDelWithArgs;
	//public static event MyDelWithArgs MyEventWithArgs;

	public static Func<string> EventString;
//	public delegate string DelString ();
//	public static DelString EventString ();

	public static Func<string,string> EventReturnArgs;
	//public delegate string DelReturnWithArgs(string s);
	//public static delReturnWithArgs EventReturnWithArgs;

	void Start () {

		//string data = EventRetrunArgs("Cat");
		MyEvent();
		EventWithArgs ("Hello World");
	}
}
