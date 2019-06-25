using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {
	//public GameObject Player;
	private float a=10.0f;
	// Use this for initialization
	void Start () {
		// Transform playerTransform = Player.transform;
		// Vector3 position = playerTransform.position;
		 //a =  position.y-9.8f;
		// Debug.Log(a);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		Vector3 pos = new Vector3(0.0f,a,0.0f);
		transform.position = pos;
		//a+=9.8f;
	}

	 void OnTriggerEnter2D(Collider2D other)
	{
		Destroy(other.gameObject);
	}
}
