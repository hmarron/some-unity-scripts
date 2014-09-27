using UnityEngine;
using System.Collections;

public class LockAxis : MonoBehaviour {
	
	public string axis;
	
	private float position;
	
	// Use this for initialization
	void Start () {
		if(axis == "X"){
			position = transform.position.x;
		}else if(axis == "Y"){
			position = transform.position.y;
		}else if(axis == "Z"){
			position = transform.position.z;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(axis == "X" && transform.position.x != position){
			transform.position = new Vector3(position, transform.position.y, transform.position.z);
		}else if(axis == "Y" && transform.position.y != position){
			transform.position = new Vector3(transform.position.x, position, transform.position.z);
		}else if(axis == "Z" && transform.position.z != position){
			transform.position = new Vector3(transform.position.x, transform.position.y, position);
		}
	}
}
