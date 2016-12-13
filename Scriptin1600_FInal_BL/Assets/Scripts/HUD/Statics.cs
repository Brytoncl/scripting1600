using UnityEngine;
using System.Collections;

public class Statics : MonoBehaviour {
	//score stats
	public static int score = 0;

	//default player stats
	public static int playerHealth = 100;
	public static float HealthRegenSpeed = .05f;

	//default enemy stats
	public static int enemyMaxHealth = 100; 
	public static int enemyinstaHealth = 1;

	//active weapon stats
	public static int ActiveWeaponDamage;
	public static int ActiveMagazine;
	public static int ActiveMagazineSize;
	public static int ActiveReserves;
	public static int ActiveMaxReserves;
	public static float ActiveReloadTime;

	public static bool canShoot = true;
	public static bool canReload = true;
	public static bool canSwap;

	//spawn system
	public static int waveNumber;
	public static float spawnFrequency = 5.5f;
	public static int spawnableEnemies = 0;
	public static int activeEnemies = 0;

	//powerup stats
	public static float instaKillActiveTime = 30;
	//public static int DoublePointsActiveTime = 30;

	//bonus
	public static int yourAnswer = 0;

	public static void Answer (int yourAnswer) {

		switch (yourAnswer) {
		case 1:
			print ("You answerd Clayton. Correct Anthony is your favorite teacher");
			break;
		case 2:
			print ("You answerd Marty. Correct Anthony is your favorite teacher");
			break;
		case 3: 
			print ("You answerd Rodayne. Correct Anthony is your favorite teacher");
			break;
		case 4:
			print ("You answerd Anthony. Correct Anthony is your favorite teacher");
			break;
		default:
			print ("Prefer not to answer. Correct Anthony is your favorite teacher");
			break;
		}
	}
}
