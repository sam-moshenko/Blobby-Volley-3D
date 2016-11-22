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
		if (collision.gameObject.CompareTag ("Ball")) {
			GameObject ball = collision.gameObject;

			if (ball.transform.position.z < transform.position.z) {
				firstPlayerScoreCount++;
				firstPlayerScoreText.text = firstPlayerScoreCount.ToString ();
			} else {
				secondPlayerScoreCount++;
				secondPlayerScoreText.text = secondPlayerScoreCount.ToString ();
			}

			if (ball) {
				Destroy (ball);
				Instantiate (ballTemplate);
			}
		}
	}
}
