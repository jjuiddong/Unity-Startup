using UnityEngine;
using System.Collections;

public class AnimationSample : MonoBehaviour {

	Animator animator;


	// Use this for initialization
	void Start () {
		animator = GetComponent (typeof(Animator)) as Animator;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			animator.Play("walk2");
		}

	}
}
