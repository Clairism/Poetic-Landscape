using UnityEngine;
using System.Collections;

public class ColorScript : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
		//GameObject.Find("Blue1").GetComponent<MeshRenderer>().material.color = Color(255,0,0);
		//GameObject.Find ("Pink Halo").GetComponent<Halo> ().color = Color.red;
		GameObject.Find ("Blue1").GetComponent<MeshRenderer> ().material.color = Color.red;
	}
	
}
