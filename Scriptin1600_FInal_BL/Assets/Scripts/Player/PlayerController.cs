using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


	private CharacterController myCC;
	private Vector3 moveDirection = Vector3.zero;
	public float moveSpeed = 5;
	public float rotateSpeed = 1;

	void Start () {
			myCC = GetComponent<CharacterController> ();
			}
	void Rotate (float _myInput) 
	{
			transform.Rotate (0, _myInput*rotateSpeed, 0);
		}

	IEnumerator ReloadTime() {
		int i;
		yield return new WaitForSeconds (Statics.ActiveReloadTime);
		i = (Statics.ActiveMagazineSize -= Statics.ActiveMagazine);
		Statics.ActiveReserves -= i;
		Statics.ActiveMagazine = Statics.ActiveMagazineSize;
		//problem where it will reload if reserves arent great enough.

	}

	public void Reload () {
		StartCoroutine (ReloadTime());
	}
	public void SwitchWeapons () 
	{

	}
	public void PickUp () {

	}
		
	void Update () {
		if (Input.GetKeyUp (KeyCode.R)) {
			Reload ();
		}
		moveDirection = new Vector3(Input.GetAxis("Vertical"),0,0);
		moveDirection = transform.TransformDirection (moveDirection*moveSpeed*Time.deltaTime);
					Rotate (Input.GetAxis ("Horizontal"));
		myCC.Move (moveDirection);
				}
		}
