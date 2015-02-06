using UnityEngine;
using System.Collections;

public class SpecEnemy1Weapon : MonoBehaviour {

	public Transform spec1Source; //source of the weapon
	public GameObject spec1weapon;
	//single weapon with a spread of 5 projectiles, fired every 3 seconds
	private float spec1FireRate = 3.0f;
	private float spec1FireDelay;

	// Use this for initialization
	void Start () {
		//spec1Bullet bullet = spec1weapon.GetComponent<spec1Bullet>();
		InvokeRepeating ("Fire", spec1FireDelay, spec1FireRate);
	}
	public void Spec1UseWeapon(){
		if (spec1Source) {
			GameObject Special1Proj = (GameObject)Instantiate(spec1weapon, spec1Source.position, spec1Source.rotation);

		}
	}
	// Update is called once per frame
	void Update () {
		
	}
	public float activeFiringRate( ) {
		return spec1FireRate;
	}
	void Fire(){
		Instantiate (spec1weapon, spec1Source.position, spec1Source.rotation);
	}
}
