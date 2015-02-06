using UnityEngine;
using System.Collections;

public class spec1Move : MonoBehaviour
{
	public GameObject shot;
	public Transform shotSpawn;
	public GameObject enemyExplosion;
	public float fireRate;
	public float delay;

	private GameObject target;
	private Transform tarTrans;
	public Transform spec1transform;
	private int rotationSpeed = 2;

	//Completely revamped spec1Move file that takes into account aiming and firing
	void Start ()
	{
		InvokeRepeating ("Fire", delay, fireRate);
		target = GameObject.FindWithTag("Player");
		tarTrans = target.transform;
	}

	void Update(){
		shot.GetComponent<master_bullet> ().isCreator ("Enemy");
		spec1transform.rotation = Quaternion.Slerp (spec1transform.rotation, Quaternion.LookRotation (tarTrans.position - spec1transform.position), rotationSpeed * Time.deltaTime);
		//spec1transform.LookAt(target.transform);
	}
	
	void Fire ()
	{
		Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
		//Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
	}

	/*void OnTriggerEnter(Collider col1){
				if (col1.tag == "Projectile") {
						Instantiate (enemyExplosion, transform.position, transform.rotation);
						Destroy (col1.gameObject);
						Destroy (gameObject);
				}
		}*/
}
