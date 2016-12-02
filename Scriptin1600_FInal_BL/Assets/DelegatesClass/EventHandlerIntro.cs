using UnityEngine;
using System.Collections;

public class EventHandlerIntro : MonoBehaviour {

	// Use this for initialization
	void Start () {
		delegateClass.MyEvent += MyEventHandler;
		delegateClass.EventWithArgs += EventWithArgsHandler;
	//	delegateClass.EventString += EventStringHandler;
	//	delegateClass.EvenReturnArgs += EventReturnArgsHandler;
	}
	public string EventReturnArgsHandler(string s)
	{
		return "the animal I hate most is " + s;
	}
	public void EventWithArgsHandler (string s) {
		print (s);
	}
	public void MyEventHandler () {
		print ("print");
	}
		public void EventStringHandler () {
		}
	}
