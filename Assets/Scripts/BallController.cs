using UnityEngine;
using System.Collections;
using System;

public class BallController : MonoBehaviour {
	public int initialForceMultiplier = 1;
	Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody> ();
		rigidbody.useGravity = false;
	}

	void OnCollisionEnter() {
		rigidbody.useGravity = true;
	}
}
