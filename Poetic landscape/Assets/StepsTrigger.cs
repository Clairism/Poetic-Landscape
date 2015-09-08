using UnityEngine;
using System.Collections;

public class StepsTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other) {
		GameObject.Find("Step.0").SetActive(false);
	}
}
