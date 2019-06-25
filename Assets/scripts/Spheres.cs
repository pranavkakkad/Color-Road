using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spheres : MonoBehaviour {
	public GameObject Player;
	void Start(){
		 StartCoroutine("Destroying");
	}
	IEnumerator Destroying(){
		yield return new WaitForSeconds(3f);
	} 
}
