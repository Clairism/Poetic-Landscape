using UnityEngine;
using System.Collections;

public class StepsTrigger : MonoBehaviour {

	public GameObject steps;

	// Use this for initialization
	void Start () {
		//steps = null;
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter (Collider other) {
		steps = GameObject.Find("Step.0");
		steps.SetActive(false);
		// GameObject.Find("Step.0").transform.position = new Vector3( 1000000, 0, 0); //super hack
	}
}
