using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject Player;
	// private Vector3 offset;
	private float offset;
	private float pos;
	// Use this for initialization
	void Start () {
		offset = transform.position.y-Player.transform.position.y;
		Debug.Log(offset);
	}
	
	// Update is called once per frame
	void Update () {
		pos = Player.transform.position.y+offset;
		transform.position =new Vector3(0,pos,-10);
	}
}
