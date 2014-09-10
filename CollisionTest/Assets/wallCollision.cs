using UnityEngine;
using System.Collections;

public class wallCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("start wallCollision");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void  OnCollisionEnter2D(Collision2D collision)
	{
		print ("collision");

		collision.rigidbody.AddForce(new Vector3(0, 500, 0));

	}

}

