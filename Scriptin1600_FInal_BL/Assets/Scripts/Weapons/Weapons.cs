using UnityEngine;
using System.Collections;

	public class Weapons : MonoBehaviour {

		public WeaponsList myWeaponsList;

		//the game object name 
		public int firePower;
		public int magazine;
		public float reloadTime; 
		public int reserveAmmo;
		public int magazineSize;
		public int maxReserves;
		int _i;
	public GameObject [] WeaponsArray;

	void Awake () {
		WeaponsArray = GameObject.FindGameObjectsWithTag ("Weapon");
	}
		
		void OnMouseUp () {
			if (myWeaponsList.myWeapons.Count < 2) {
				myWeaponsList.myWeapons.Add (this);
				gameObject.SetActive (false);
			print ("You Picked Up The"+ " " + gameObject.name);
			} else
				print ("Weapon Inventory Full");
		}
	//IEnumerator
	void Reload (){
		if (Input.GetKeyDown (KeyCode.R) && myWeaponsList.myWeapons [0].magazine == 0 && myWeaponsList.myWeapons  [0].reserveAmmo > 0) {
			//yield return new WaitForSeconds (reloadTime); 
			myWeaponsList.myWeapons [0].magazine += myWeaponsList.myWeapons  [0].magazineSize;
			myWeaponsList.myWeapons [0].reserveAmmo -= myWeaponsList.myWeapons [0].magazineSize;
			print ("Weapon Loaded");
		}

	}
	void Update (){
		Reload ();
	}
}