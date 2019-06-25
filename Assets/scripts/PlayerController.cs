using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	
	Vector3 target;
	private float speed=0.2f;
	private Rigidbody rb;
	void Start () {
		 rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate(){
		//min -1.6
		//max=1.5
		if (Input.GetMouseButton(0)) {
             target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
             target.z = transform.position.z;
			 target.y = transform.position.y+0.2f;
			 transform.position = Vector3.MoveTowards(transform.position, target, speed);
			  Vector3 clampedPosition = transform.position;
			 clampedPosition.x = Mathf.Clamp(clampedPosition.x, -1.6f, 1.5f);
			//  clampedPosition.x = clampedPosition.x*speed;
			 transform.position = clampedPosition;
			//  Debug.Log(transform.position.x);
			//  rb.AddForce(Vector3.MoveTowards(transform.position, target, speed));
         }
		 else {
			  Debug.Log("Entere herere");
			transform.position+=Vector3.up*speed;
		 }
		
	}
}
