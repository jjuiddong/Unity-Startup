using UnityEngine;
using System.Collections;

public class Janpa : MonoBehaviour {

	public GameObject ball;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider obj) {
		print ("TriggerEnter");
		Destroy (obj.gameObject);	

		Vector3 pos;
		pos.x = 0;
		pos.y = 2;
		pos.z = 0;

		Instantiate ( ball, pos, Quaternion.Euler(0,0,0) );

		SendMessage ("GameManager.OutBall");

	}

}
