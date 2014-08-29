using UnityEngine;
using System.Collections;

public class Plane : MonoBehaviour {

	public GameObject coinPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collider)
	{
		print ("trigger");
		Instantiate (coinPrefab, new Vector3 (0, 8, 0), Quaternion.Euler (0, 0, 0));
	}

}
