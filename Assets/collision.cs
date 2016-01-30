using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour {
	public int col;

	void OnCollisionEnter2D(Collision2D collide){

		if(collide.gameObject.CompareTag("leftwall") || collide.gameObject.CompareTag("rightwall")){}

		col = -1;

	}
}
