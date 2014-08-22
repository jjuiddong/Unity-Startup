using UnityEngine;
using System.Collections;

public class Ground2 : MonoBehaviour {

	public float _time = 0;
	public GameObject replay;
	public GUIText textGui;
	public bool isReplay = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		_time += Time.deltaTime;
		textGui.text = _time.ToString ();
	
		if (!isReplay && _time > 5)
		{
			replay.SetActive(true);
			isReplay = true;
		}

	}
}
