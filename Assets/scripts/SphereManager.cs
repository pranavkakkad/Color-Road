using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereManager : MonoBehaviour {

	public GameObject[] Sphere;
	public GameObject Player;
	float y=0,x;
	int ranNumber;
	float delay = 2.0f;
	private GameObject[] Temp;
	private int a=0,cnt=0;

	//private GameObject[] Sphere = new GameObject[] {Sphere1,"Sphere2","Sphere3","Sphere4","Sphere5","Sphere6"};
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void GenerateSpheres(float t){
		Debug.Log("In Sphere Manager");
		y=t;
		int a = Random.Range(0,5);
		for(int i=0;i<a;i++){
			y+=2;
			x=2f;//Random.Range(1.3f,2.3f);
			ranNumber=Random.Range(0,5);
			Debug.Log("ranNumber"+ ranNumber);
			GameObject sp=Instantiate(Sphere[i],new Vector3(x,y,-0.6510f),Quaternion.identity);
			//Temp[cnt++]=sp;
			sp.SetActive(true);
		}
	}
}
