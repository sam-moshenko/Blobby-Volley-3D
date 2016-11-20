using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	Rigidbody rigidbody;
	public float multiplier = 100;
	public float jumpForce = 30;

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		float vertical = Input.GetAxis ("Vertical");
		float horizontal = Input.GetAxis ("Horizontal");
		bool jump = Input.GetKeyDown (KeyCode.Space);

		Vector3 force = new Vector3 (horizontal, 0, vertical) * multiplier;
		force += GetMouseVector ();

		rigidbody.AddForce (force);
		if (transform.position.y < 5) {
			rigidbody.AddForce (0, (jump == true ? jumpForce : 0.0f), 0);
		}
	}

	Vector3 GetMouseVector () {
		float verticalMouse = Input.GetAxis ("Mouse Y");
		float horizontalMouse = Input.GetAxis ("Mouse X");

		Vector3 mouseForce = new Vector3 (horizontalMouse, 0, verticalMouse);

		if (mouseForce.sqrMagnitude > 1) {
			mouseForce = mouseForce.normalized * multiplier;
		}

		return mouseForce;
	}
}
