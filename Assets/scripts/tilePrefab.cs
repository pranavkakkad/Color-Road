using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilePrefab : MonoBehaviour {
	public GameObject tile;
	public Vector3 min;
    public Vector3 max;
	public tileSpawn t;
	

	void Update(){
		 
		//  Debug.Log(min);
		//  Debug.Log(max);
	}
 
	void OnTriggerEnter(Collider other)
	{
		Debug.Log("HI==>"+ other.gameObject.name);
		t.GeneratePrefab();
		
		
		//Instantiate(tile,new Vector3(transform.position.x,transform.position.y,transform.position.z),Quaternion.identity);
	}
	// float UpdatePosition(){
	// 	min = gameObject.GetComponent<SpriteRenderer>().bounds.min;
    //     max = gameObject.GetComponent<SpriteRenderer>().bounds.max;
	// 	return min,max;
	// }
}
