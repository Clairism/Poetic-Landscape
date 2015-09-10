using UnityEngine;
using System.Collections;

public class DIsappear : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	
	void OnTriggerEnter(Collider other) {

		GameObject.Find("Purple").GetComponent<MeshRenderer>().enabled = true ;

		GameObject.Find("Green2").transform.Rotate(new Vector3( 50f, 0, 0) );
		GameObject.Find ("Green1").transform.Rotate (new Vector3 (-50f, 0, 0));

		GameObject.Find("Blue1").transform.Translate(Vector3.forward * 3f);
		GameObject.Find("Blue3").transform.Translate(Vector3.back * 3f);
		GameObject.Find("Green3").transform.Translate(Vector3.left * 5f);

	}

	void OnTriggerExit(Collider other) {
		GameObject.Find("Purple").GetComponent<MeshRenderer>().enabled = false;
		GameObject.Find("Green3").transform.Translate(Vector3.right * 5f);

	}
	

}
