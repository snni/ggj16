using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	public float gravity = 0.3f;
	public float vspeed = 0.1f;
	public GameObject Player;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		vspeed += 0.01f;
		float h = Input.GetAxis("Horizontal");
		float v = -(gravity * vspeed);

		Player.transform.Translate(h*Time.deltaTime,v*Time.deltaTime,0);


	}


}
