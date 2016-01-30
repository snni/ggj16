using UnityEngine;
using System.Collections;


public class collision : MonoBehaviour {
	public GameObject Player;
	// Use this for initialization
	void OnControllerColliderHit(ControllerColliderHit Player) {
		Player.gameObject.transform.position = Vector3.zero;
	}

	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
	}
}
