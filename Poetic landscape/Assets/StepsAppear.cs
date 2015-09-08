using UnityEngine;
using System.Collections;

public class StepsAppear : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other) {
		Debug.Log ("The Trigger is working!");
		//It's not!!!
		GameObject.Find("Step.0").SetActive(true);
	}
}
