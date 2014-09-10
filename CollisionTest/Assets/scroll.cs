using UnityEngine;
using System.Collections;

public class scroll : MonoBehaviour {

	float offset;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		offset += Time.deltaTime * 0.3f;
		renderer.material.mainTextureOffset = new Vector2 (offset, 0);	
	}
}
