using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {
	
	public GameObject objectToDestroy;  //eg user
	public string[] killingBulletNames; //eg bullet(Clone)
	
	void OnTriggerEnter(Collider other){
		foreach(string killName in killingBulletNames){
			if(other.name == killName){
				Destroy(objectToDestroy.gameObject);
			}
		}
	}
}
