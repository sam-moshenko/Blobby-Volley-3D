using UnityEngine;
using System.Collections;
using System;

public class BallController : MonoBehaviour {
	public int initialForceMultiplier = 1;
	Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody> ();
		rigidbody.isKinematic = true;
		rigidbody.detectCollisions = true;
	}

	void OnCollisionEnter() {
		rigidbody.isKinematic = false;
	}
}
