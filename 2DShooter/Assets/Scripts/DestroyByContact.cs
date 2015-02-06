using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {

	public GameObject explosion;
	public GameObject playerExplosion;


	//modified OnTriggerEnter for asteroids for collision with player and projectiles only
	void OnTriggerEnter(Collider other){


		if (other.tag == "Player") {
			Instantiate (explosion, transform.position, transform.rotation);
			Instantiate (playerExplosion, other.transform.position, other.transform.rotation);
			Destroy (other.gameObject);
			Destroy (gameObject);
		}
		if (other.tag == "Projectile") {
			Instantiate (explosion, transform.position, transform.rotation);
			Destroy(gameObject);
			Destroy (other.gameObject);
		}
		/*if (other.tag == "Player") {
			Instantiate (explosion, transform.position, transform.rotation);
			Instantiate (playerExplosion, other.transform.position, other.transform.rotation);
			Destroy (other.gameObject);
			Destroy (gameObject);
		}
		if (other.tag == "Enemy") {
			Instantiate (explosion, transform.position, transform.rotation);
			other.gameObject.active = false;
			Destroy(other.gameObject);
			Destroy (gameObject);
		}*/
	}
}
