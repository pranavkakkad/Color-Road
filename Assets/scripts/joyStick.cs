using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joyStick : MonoBehaviour {
	public Transform Player;
	public float speed=5.0f; 
	private bool touchStart=false;
	private Vector2 PointA;
	private Vector2 PointB;
	public Transform circle;
	public Transform outerCircle;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 temp=new Vector2(0f,2f);
		moveBall(temp);
		// moveBall(new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical")));
		if(Input.GetMouseButtonDown(0)){
			PointA =  Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,Camera.main.transform.position.z));
			// circle.transform.position=PointA*1;
			// outerCircle.transform.position=PointA*1;
		}
		if(Input.GetMouseButton(0)){
			touchStart=true;
			PointB =  Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,Camera.main.transform.position.z));
			// circle.GetComponent<SpriteRenderer>().enabled=true;
			// outerCircle.GetComponent<SpriteRenderer>().enabled=true;
		}
		else{
			touchStart=false;
		}
	}

	void FixedUpdate(){
		if(touchStart){
			Vector2 offset = PointB-PointA;
			Vector2 direction = Vector2.ClampMagnitude(offset,1.0f);
			moveBall(direction*1);
			//circle.transform.position=new Vector3(PointA.x+direction.x,PointA.y+direction.y,-0.6510f)*1;
		}
		else{
			//circle.GetComponent<SpriteRenderer>().enabled=false;
			//outerCircle.GetComponent<SpriteRenderer>().enabled=false;
		}
	}
	void moveBall(Vector2 direction){
		Player.Translate(direction*speed*Time.deltaTime);
	}
}
