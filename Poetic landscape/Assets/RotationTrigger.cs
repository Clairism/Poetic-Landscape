using UnityEngine;
using System.Collections;

public class RotationTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update (){	
		//how to make it keep rotating(entering)?

		
	}
	
	void OnTriggerEnter(Collider other) {

		GameObject.Find("Pool.00").transform.Rotate( new Vector3( 5f, 0, 0) );
		}


}
