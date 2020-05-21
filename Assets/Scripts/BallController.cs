using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class BallController : MonoBehaviour {

	public GameObject plane;
	public GameObject spawnPoint;
	public Text time;
	public Text score;
	public Text gameOver;
	public Button back;

	private int seconds;
	private int count;

	void Start () {
		seconds = 0;
		count = 0;
	}

	void Update (){
	seconds += 1;
	time.text = "Time: " + (seconds/60).ToString ();

	}

	void LateUpdate() {
		if (transform.position.y < plane.transform.position.y - 10) {

			transform.position = spawnPoint.transform.position;
		}		
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Picks"))
		{
			other.gameObject.SetActive (false);

			count = count + 1;

			SetCountText ();
		}
		else if (other.gameObject.CompareTag ("Finish")) {
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
			back.gameObject.SetActive (true);
			gameOver.gameObject.SetActive (true);
			Time.timeScale = 0;
		}
	}

	void SetCountText()
	{
		score.text = "Current Score: " + count.ToString ();
	}
}