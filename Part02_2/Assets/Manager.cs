using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

	public int Count;
	public float _time;
	bool End;
	public GUIText Text_Time;
	public GameObject ClearGUI;

	// Use this for initialization
	void Start () {
		print ("Manager Start");
		End = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!End)
			_time += Time.deltaTime;

		if (_time > 5) {
			print ("active");
			ClearGUI.SetActive(true);
		}

		Text_Time.text = _time.ToString();
	}

	void OnTriggerEnter (Collider Get)
	{
		print ("TiggerEnter");

		if (Get.collider.tag == "Box") 
		{
			print ("TiggerEnter Box");
			++Count;
		}
	}

}
