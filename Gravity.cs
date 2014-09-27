﻿using UnityEngine;
using System.Collections.Generic;
 
public class Gravity : MonoBehaviour 
{	
	public float range = 10000;
	public float mass;
	
	void Start () {
		if(rigidbody != null){
			mass = rigidbody.mass;	
		}
	}
 
	void FixedUpdate () 
	{
		Collider[] cols  = Physics.OverlapSphere(transform.position, range); 
		List<Rigidbody> rbs = new List<Rigidbody>();
 
		foreach(Collider c in cols)
		{
			Rigidbody rb = c.attachedRigidbody;
			if(rb != null && rb != rigidbody && !rbs.Contains(rb))
			{
				rbs.Add(rb);
				Vector3 offset = transform.position - c.transform.position;
				rb.AddForce( offset / offset.sqrMagnitude * mass);
			}
		}
	}
}