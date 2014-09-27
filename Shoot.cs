using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	
	public Rigidbody bullet;
	public float speed;
	public int playerNum;
	public Transform bulletSpawn;
	public Transform target;
	
	private bool canShoot = true;
	
	void Update () {
		if(Input.GetButtonDown("Fire " + playerNum)){
			Rigidbody clone;
			clone = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
			Physics.IgnoreCollision(clone.collider,collider);
			
			clone.velocity = transform.TransformDirection(target.localPosition * speed);
			canShoot = false;
		}
		
		if(Input.GetAxis("Fire " + playerNum) < 0.1){
			canShoot = true;
		}
	}
}
