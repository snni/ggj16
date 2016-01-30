using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	public float gravity = 0.3f;
	public float vspeed = 0.1f;
	public GameObject Player;
	public AudioSource clickAudio;
	public AudioSource kissAudio;
	// Use this for initialization
	void Start () {
	}

	void OnCollisionEnter2D(Collision2D collide){

		if (collide.gameObject.CompareTag ("leftwall") || collide.gameObject.CompareTag ("rightwall")) {
			clickAudio.Play ();
		}
		if (collide.gameObject.CompareTag ("heart")) {
			kissAudio.Play ();
			Destroy(collide.gameObject);
			Debug.Log("Other object is a coin");
		}
	}


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("heart")) {
			Destroy(other.gameObject);
			Debug.Log("Other object is a coin");
		}
	}
	// Update is called once per frame
	void Update () {
		
		vspeed += 0.01f;
		float h = Input.GetAxis("Horizontal");

		Player.transform.Translate(h*0.1f,0,0);



	}


}
