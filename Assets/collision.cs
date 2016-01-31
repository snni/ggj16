using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour {
	public int col;
	public AudioSource clickAudio;
	void OnCollisionEnter2D(Collision2D collide){

		if(collide.gameObject.CompareTag("leftwall") || collide.gameObject.CompareTag("rightwall")){}
		clickAudio.Play ();
		col = -1;

	}



}