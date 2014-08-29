using UnityEngine;
using System.Collections;

public class Janpa : MonoBehaviour {

	int count = 0;
	public GameObject ball;
	public GameObject gameManager;
	public GameObject realManager;

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

		gameManager.SendMessage ("OutBall");
		realManager.SendMessage ("ScoreUp");

		++count;
		if (count > 3) {
			Application.LoadLevel("scene2");
		}
	}

}
