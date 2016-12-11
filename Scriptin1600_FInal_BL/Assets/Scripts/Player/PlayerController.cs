using UnityEngine;
using System.Collections;

public class PlayerController : HUD {


	private CharacterController myCC;
	private Vector3 moveDirection = Vector3.zero;
	public float moveSpeed = 5;
	public float rotateSpeed = 1;

	public override void UpdateHUD ()
	{
		ammoText.text = "Ammo: " + Statics.ActiveMagazine;
		reservesText.text = "reserves: " + Statics.ActiveReserves;
	}

	void Start () {
			myCC = GetComponent<CharacterController> ();
		UpdateHUD();
			}
	void Rotate (float _myInput) 
	{
			transform.Rotate (0, _myInput*rotateSpeed, 0);
		}

	IEnumerator ReloadTime() {
		if (Statics.ActiveMagazineSize <= Statics.ActiveReserves) {
			PrintReload ();
			yield return new WaitForSeconds (Statics.ActiveReloadTime);
			Statics.ActiveReserves -= Statics.ActiveMagazineSize;
			Statics.ActiveMagazine = Statics.ActiveMagazineSize;
			yield return new WaitForSeconds (.01f);
			UpdateHUD ();
			Statics.canReload = true;
			Statics.canShoot = true;
		}
		//reload time isnt working yet and you can shoot while reloading. 

	}

	public void Reload () {
		if (Statics.canReload == true && Statics.ActiveMagazine != Statics.ActiveMagazineSize) {
			Statics.canReload = false;
			Statics.canShoot = false;
			StartCoroutine (ReloadTime ());
		}
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

		//bonus question
		if (Input.GetKeyDown (KeyCode.Space)) {
			Statics.yourAnswer = 4;
		}
		if (Input.GetKeyDown (KeyCode.U)) {
			Statics.yourAnswer = 3;
		}
		if (Input.GetKeyDown (KeyCode.X)) {
			Statics.yourAnswer = 2;
		}
		if (Input.GetKeyDown (KeyCode.P)) {
			Statics.yourAnswer = 1;
		}
				}
		}
