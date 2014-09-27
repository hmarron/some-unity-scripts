using UnityEngine;
using System.Collections;

public class Chase : MonoBehaviour {
	
	public GameObject chaser;
	public int speed;
	public GameObject user;
	private bool seen = false;
	public string[] thingsToChase;
	private Collider playerSeen;
	
	void Update () {
		if(seen){
			user.transform.LookAt(playerSeen.transform);
			user.transform.Translate(playerSeen.transform.forward * Time.deltaTime * speed);
		}
	}
	
	void OnTriggerEnter(Collider other){
		foreach(string player in thingsToChase){
			if(other.name == player){
				seen = true;
				playerSeen = other;
			}
		}

	}
}
