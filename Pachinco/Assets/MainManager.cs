using UnityEngine;
using System.Collections;

public class MainManager : MonoBehaviour {

	static int score = 0;
	public GUIText guiText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = score.ToString ();
	}

	void ScoreUp() {
		score++;
		print ("ScoreUp");
	}

}
