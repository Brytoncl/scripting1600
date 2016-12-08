using UnityEngine;
using System.Collections;

public class Statics : MonoBehaviour {
	//score stats
	public static int score = 0;

	//default base stats
	public static int playerHealth = 100;
	public static int enemyMaxHealth = 100; 

	//active weapon stats
	public static int ActiveWeaponDamage;
	public static int ActiveMagazine;
	public static int ActiveMagazineSize;
	public static int ActiveReserves;
	public static int ActiveMaxReserves;
	public static float ActiveReloadTime;

	//spawn system
	public static int waveNumber;
	public static float spawnFrequency = 5.5f;
	public static int spawnableEnemies = 0;
	public static int activeEnemies = 0;

}
