using UnityEngine;
using System.Collections;

public class Rotating : MonoBehaviour {

	public float rotationAmount = 0;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {

		//transform.Rotate = new Vector3 (rotationAmount, 0, 0);
		transform.Rotate(Vector3.up * rotationAmount * Time.deltaTime);
	
	}
}
