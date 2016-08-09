using UnityEngine;
using System.Collections;

	[System.Serializable]
	public class Weapons : MonoBehaviour {



		public WeaponsList myWeaponsList;

		//the game object name 
		public int firePower;
		public int magazine;
		public float reloadTime; 
		public int reserveAmmo;
		public int magazineSize;
		public int maxReserves;
		public int defaultFirePower;
		int _i;

	public Weapons[] WeaponsStatsArray;
	public GameObject [] WeaponsArray;

	public void DamageBoost () {
		foreach (Weapons item in WeaponsStatsArray) {
			item.firePower = 100;
			print (item.name);
		}
	}
	public void DefaultDamage () {
			foreach (Weapons item in WeaponsStatsArray){
			item.firePower = item.defaultFirePower;
			print (item.name);
			}
		}

	void Awake () {
		WeaponsArray = GameObject.FindGameObjectsWithTag ("Weapon");
	}
		void OnMouseUp () {
			if (myWeaponsList.myWeapons.Count < 2) {
				myWeaponsList.myWeapons.Add (this);
				gameObject.SetActive (false);
				myWeaponsList.UpdateWeaponType ();
			print ("You Picked Up The "+ gameObject.name);
			} else
				print ("Weapon Inventory Full");
		}
}