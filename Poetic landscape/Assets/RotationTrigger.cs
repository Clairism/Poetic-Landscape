using UnityEngine;
using System.Collections;

public class RotationTrigger : MonoBehaviour {

	//public float rotationAmount = 0;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update (){

		//how to make it keep rotating(entering)
		//GameObject.Find("Pool.00").transform.Rotate( new Vector3(rotationAmount, 0, 0) );
		
	}

	void OnTriggerEnter(Collider other) {
		GameObject.Find ("Pool.00").GetComponent<Rotating>().rotationAmount = 5f;
		//GameObject.Find("Pool.00").GetComponent<Rigidbody>().AddTorque( new Vector3(50, 0, 0) ); 
		//transform.Rotate( new Vector3( 5f, 0, 0) );

	}


}
