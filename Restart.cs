using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

	void Update () {
		if(Input.GetButtonDown("Restart")){
			Application.LoadLevel(0);
		}
	}
}
