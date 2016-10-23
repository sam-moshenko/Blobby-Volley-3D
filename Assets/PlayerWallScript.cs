using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerWallScript : MonoBehaviour {
	public GameObject ballTemplate;

	public Text firstPlayerScoreText;
	public Text secondPlayerScoreText;

	private int firstPlayerScoreCount;
	private int secondPlayerScoreCount;

	// Use this for initialization
	void Start () {
	
	}
	

	void OnCollisionEnter(Collision collision) {
		print ("OnTriggerExit with object" + collision.gameObject.tag);
		if (collision.gameObject.CompareTag ("Ball")) {
			print ("ball triggered");
			GameObject ball = collision.gameObject;

			if (ball.transform.position.z < transform.position.z) {
				firstPlayerScoreCount++;
				firstPlayerScoreText.text = firstPlayerScoreCount.ToString ();
			} else {
				secondPlayerScoreCount++;
				secondPlayerScoreText.text = secondPlayerScoreCount.ToString ();
			}

			Destroy (ball);
			Instantiate (ballTemplate);
		}
	}
}
