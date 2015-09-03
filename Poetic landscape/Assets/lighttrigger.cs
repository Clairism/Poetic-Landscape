using UnityEngine;
using System.Collections;

public class lighttrigger : MonoBehaviour {
	private GameObject bbc;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//when a player walks through the trigger
	void OnTriggerEnter(Collider other) {
	//get the light of this game object, and turn it off
	gameObject.GetComponent<Light>().enabled = false;

	//find the dead person and make it disappear
		bbc = GameObject.Find ("Person");
		bbc.SetActive(false);
	}

	void OnTriggerExit(Collider other) {
		gameObject.GetComponent<Light>().enabled = true;

		bbc.SetActive(true);

	}

}
