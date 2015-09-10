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
		//GameObject.Find("Step.0").SetActive(true);
		//GameObject.Find("Step.0").transform.position = new Vector3( -55.9f, -2.6f, -71.51f); //super hack =.=

		GameObject.Find ("Trigger").GetComponent<StepsTrigger>().steps.SetActive(true);
	}
}
