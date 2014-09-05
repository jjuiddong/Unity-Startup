using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	public Sprite[] sprites;
	float aniTime = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		aniTime += Time.deltaTime*5;
		int aniIndex = (int)aniTime;

		if (aniIndex >= sprites.Length) {
			aniIndex = 0;
			aniTime = 0;
		}

		transform.position += new Vector3 (-1, 0, 0) * Time.deltaTime;
		GetComponent<SpriteRenderer>().sprite = sprites [aniIndex];
	
	}
}
