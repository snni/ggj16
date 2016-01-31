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
			scoreText.text = "Hearts Collected : "+ score.ToString();		
		}

		if (collide.gameObject.CompareTag ("goal")) {
			weeAudio.Play ();
			death = true;
			Debug.Log("I'm happy to die for my master");
	
		}
		}

	
	// Update is called once per frame
	void Update () {
		if(death && weeAudio.isPlaying == false)
			Destroy(Player);
		vspeed += 0.01f;
		float h = Input.GetAxis("Horizontal");

		Player.transform.Translate(h*0.1f,0,0);



	}


}
