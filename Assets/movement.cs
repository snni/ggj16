using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class movement : MonoBehaviour {

	public float gravity = 0.3f;
	public float vspeed = 0.1f;
	public GameObject Player;
	public AudioSource clickAudio;
	public AudioSource kissAudio;
	public Text scoreText;
	// Use this for initialization
	void Start () {
	}
	private int score = 0;
	void OnCollisionEnter2D(Collision2D collide){
		
		if (collide.gameObject.CompareTag ("leftwall") || collide.gameObject.CompareTag ("rightwall")) {
			clickAudio.Play ();
		}
		if (collide.gameObject.CompareTag ("heart")) {
			kissAudio.Play ();
			Destroy(collide.gameObject);
			Debug.Log("It's a heart!");
			score += 1;
			scoreText.text = "Hearts Collected : "+ score.ToString();		
		}
		}

	
	// Update is called once per frame
	void Update () {
		
		vspeed += 0.01f;
		float h = Input.GetAxis("Horizontal");

		Player.transform.Translate(h*0.1f,0,0);



	}


}
