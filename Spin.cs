﻿using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {
	
	public float speed;
	
	void Update () {
		transform.Rotate(Vector3.forward * Time.deltaTime * speed);
	}
}
