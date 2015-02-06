using UnityEngine;
using System.Collections;

public class master_bullet : MonoBehaviour {
	public float damage;
	private float fireRate;
	private string creator;
	public float speed;

	// Use this for initialization
	void Start () {
		rigidbody.velocity = transform.forward * speed;
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (this.gameObject, 2);
	}
	public string byWho() {
		return creator;
	}
	public void isCreator( string name ) {
		creator = name;
	}

	//modified OnTriggerEnter to take into account the creator and tag of the collided target
	void OnTriggerEnter( Collider target ) {
		print ("Creator is: " + creator + ", tag is: " + target.tag + "!");

		if (target.tag == "Player" && creator == "Player") {

		} else if (target.tag == "Enemy" && creator == "") {

		} else {
			Destroy(gameObject);
			Destroy(target.gameObject);
		}
	}
	public float FireRate() {
		return fireRate;
	}
}
