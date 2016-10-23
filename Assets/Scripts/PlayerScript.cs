using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	Rigidbody rigidbody;
	public float multiplier = 100;

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		float vertical = Input.GetAxis ("Vertical");
		float horizontal = Input.GetAxis ("Horizontal");
		bool jump = Input.GetKeyDown (KeyCode.Space);

		Vector3 force = new Vector3 (-vertical, (jump == true ? 10.0f : 0.0f), horizontal) * multiplier;
		rigidbody.AddForce (force);
	}
}
