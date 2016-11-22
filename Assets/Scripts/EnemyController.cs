using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	public float multiplier = 100;
	public float jumpForce = 1000;
	public float distanceToBallToJump = 10;
	public float distanceToGroundToJump = 2;
	Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent <Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		GameObject ball = GameObject.FindGameObjectWithTag ("Ball");
		Rigidbody ballRigidbody = ball.GetComponent<Rigidbody> ();
		Vector3 ballPositionXZ = new Vector3 (ball.transform.position.x, 0, ball.transform.position.z);
		Vector3 ballVelocityXZ = new Vector3 (ballRigidbody.velocity.x, 0, ballRigidbody.velocity.z);
		Vector3 enemyPositionXZ = new Vector3 (transform.position.x, 0, transform.position.z);

		Vector3 vectorToBall = ballPositionXZ - enemyPositionXZ;
		bool jump = false;
		if (vectorToBall.sqrMagnitude < distanceToBallToJump && transform.position.y < distanceToGroundToJump) {
			jump = true;
		}
		vectorToBall.Normalize ();
		rigidbody.AddForce (vectorToBall * multiplier);
		rigidbody.AddForce (ballVelocityXZ.normalized * multiplier);


		if (transform.position.y < 2) {
			rigidbody.AddForce (new Vector3 (0, jump == true ? jumpForce : 0.0f, 0));
		}
	}
}
