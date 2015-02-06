using UnityEngine;
using System.Collections;

public class spec1Bullet : MonoBehaviour {
	public float spec1Damage;
	private float Spec1FireRate = 0.3f;
	private string spec1name = "Enemy";
	public float spec1speed;

	// Use this for initialization
	void Start () {
		rigidbody.velocity = transform.forward * spec1speed * -1; //projectile moves left
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (this.gameObject, 2);
	}
	void OnTriggerEnter(Collider target){
		/*if (target.name == "Player") {
			Destroy(target);
		}*/
	}
	public float returnSpec1Rate(){
		return Spec1FireRate;
	}
}
