using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class movement : MonoBehaviour {

	public float gravity = 0.3f;
	public float vspeed = 0.1f;
	public GameObject Player;
	public AudioSource clickAudio;
	public AudioSource kissAudio;
	public AudioSource weeAudio;
	public Text scoreText;
	public Text goalText;
	public Animation deathanim;
	private bool death;
	// Use this for initialization
	void Start () {
		death = false;
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
			scoreText.text = "Hearts Stolen : "+ score;	
		}

		if (collide.gameObject.CompareTag ("goal") || collide.gameObject.CompareTag ("land")) {
			weeAudio.Play ();
			deathanim.Play ();
			death = true;
			Debug.Log("I'm happy to die for my master");
			if (collide.gameObject.CompareTag ("goal")) {
				goalText.text = "Yay!\n You finished the ritual\nsuccessfully with "+ score + " hearts";}
			if (collide.gameObject.CompareTag ("land")) {
				goalText.text = "Buu!\n You finished the ritual\nunsuccessfully with "+ score + " hearts";}

		}
	}


	// Update is called once per frame
	void Update () {
		if (death && weeAudio.isPlaying == false) {
			Destroy (Player);
		}
			
			
		vspeed += 0.01f;
		float h = Input.GetAxis("Horizontal");

		Player.transform.Translate(h*0.1f,0,0);



	}


}
