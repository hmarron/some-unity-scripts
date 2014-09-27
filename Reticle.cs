using UnityEngine;
using System.Collections;

public class Reticle : MonoBehaviour {
	
	public int playerNum;
	public int range;

	void Update () {
		transform.localPosition = new Vector3(Input.GetAxis("Aim X " + playerNum) * range, -Input.GetAxis("Aim Y " + playerNum) * range, 0);
	}
}
