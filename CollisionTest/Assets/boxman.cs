using UnityEngine;
using System.Collections;

public enum PlayerState{
	Run,
	Jump,
	Jump2,
	Death
}

public class boxman : MonoBehaviour {

	public Animator animator;
	public PlayerState state = PlayerState.Run;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.Space)) {

			if (PlayerState.Run == state)
			{
				Jump();
			}
			else if (PlayerState.Jump == state)
			{
				Jump2();
			}

		}
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		Run ();
	}

	void Jump() {
		state = PlayerState.Jump;
		animator.SetTrigger("Jump");
		animator.SetBool("Ground", false);

		rigidbody2D.AddForce (new Vector3 (0, 300, 0));
		//rigidbody2D.velocity = new Vector3 (1, 0, 0);
	}

	void Jump2() {
		state = PlayerState.Jump2;
		animator.SetTrigger("Jump2");
		animator.SetBool("Ground", false);
		rigidbody2D.AddForce (new Vector3 (0, 300, 0));
	}

	void Run() {
		state = PlayerState.Run;
		animator.SetBool("Ground", true);
		//rigidbody2D.velocity = new Vector3 (1, 0, 0);
	}

}
