using UnityEngine;
using System.Collections;
using System;

public class BallController : MonoBehaviour {
	public int initialForceMultiplier = 1;
	Rigidbody rigidbody;
	public float gravity = 1;

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody> ();
		rigidbody.useGravity = false;
	}

	void OnCollisionEnter() {
		rigidbody.useGravity = true;
	}

	void Update () {
		if (rigidbody.useGravity) {
			rigidbody.AddForce (-Physics.gravity + Physics.gravity * gravity);
		}
	}
}
