using UnityEngine;
using System.Collections;
using System;

public class BallController : MonoBehaviour {
	public int initialForceMultiplier = 1;
	Rigidbody rigidbody;
	public float gravity = 1;
	public float maxVelocity = 100;

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody> ();
		rigidbody.useGravity = false;
	}

	void OnCollisionEnter() {
		rigidbody.useGravity = true;
	}

	void Update () {
		if (rigidbody.velocity.sqrMagnitude > maxVelocity * maxVelocity) {
			rigidbody.velocity = rigidbody.velocity.normalized * maxVelocity;
		}
		if (rigidbody.useGravity) {
			rigidbody.AddForce (-Physics.gravity + Physics.gravity * gravity);
		}
	}
}
