using UnityEngine;
using System.Collections;

public class DestroyTime : MonoBehaviour {
	
	public float ttl; //time to live
	
	void Awake(){
		Destroy (gameObject, ttl);	
	}
}
