using UnityEngine;
using System.Collections;

public class LightPulse : MonoBehaviour {

	public float maxDist;
	public float speed;

	void Update () {
		light.range = Mathf.PingPong(Time.time * speed, maxDist);
	}
}
