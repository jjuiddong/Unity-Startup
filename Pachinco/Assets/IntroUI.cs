using UnityEngine;
using System.Collections;

public class IntroUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnMouseDown() {
		print ("MouseDown");
		Application.LoadLevel ("scene1");
	}

}
