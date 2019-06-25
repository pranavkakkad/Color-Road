using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileSpawn : MonoBehaviour {
	public tilePrefab tile;
	public GameObject Player;
	private SpriteRenderer sprite;
	private Rigidbody rb;
	private float m_speed =-1.5f;
	public Vector3 min;
	private float Endpos;
	public Vector3 max;
	private float startPos;
	float t=0;
	// public Spheres s;
	public SphereManager s;	
	void Awake(){
		
	}
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		tilePrefab tile1 = Instantiate(tile,new Vector3(0f,0f,-0.6510f),Quaternion.identity);
		tile1.t = this;
		t=9.8f;
		s.GenerateSpheres(t);
		
		tilePrefab tile2 = Instantiate(tile,new Vector3(0f,t,-0.6510f),Quaternion.identity);
		tile2.t = this;
		t +=9.8f;
		s.GenerateSpheres(t);
		startPos = Player.transform.localPosition.y;
	}
	
	// void Update () {
	// 	 min = tile.GetComponent<SpriteRenderer>().bounds.min;
    //      max = tile.GetComponent<SpriteRenderer>().bounds.max;
	// 	Endpos = Player.transform.localPosition.y;
	// 	//Debug.Log(Endpos);
	// 	// Debug.Log(pos);
	// 	// Debug.Log(min);
	// 	// Debug.Log(max);
	// 	Vector3 offset = new Vector3(Endpos,0,0)-new Vector3(startPos,0,0);
	// 	//Vector3 offset = Endpos.y-startPos.y;
	// 	 float sqrLen = Endpos - startPos;
	// 	 if(sqrLen>10){
	// 		GeneratePrefab();
	// 	}
	// }

	public void GeneratePrefab(){
		tilePrefab tile1 = Instantiate(tile,new Vector3(0f,t,-0.6510f),Quaternion.identity);
		Debug.Log("In Generate Prefab");
		t+=9.8f;
		startPos = Player.transform.localPosition.y;
		s.GenerateSpheres(t);
		tile1.t = this;
		//Debug.Log(startPos);
		//	y=Random.Range(-5,12);
	}
}
