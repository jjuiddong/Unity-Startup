using UnityEngine;
using System.Collections;

public enum MoleState
{
	None, 
	Open,
	Idle,
	Close,
	Catch
}


public class Hole : MonoBehaviour {

	public MoleState MS;
	public Texture[] Open_Images;
	public Texture[] Idle_Images;
	public Texture[] Close_Images;
	public Texture[] Catch_Images;
	public Texture[] _Images;

	int aniCount = 0;
	float incTime = 0;
	public float animationSpeed = 20;

	// Use this for initialization
	void Start () {
		MS = MoleState.None;

	}

	public void Open_On()
	{
		MS = MoleState.Open;
		aniCount = 0;
		incTime = 0;
	}

	public void Open_Ing()
	{
		renderer.material.mainTexture = Open_Images [aniCount];	

		incTime += Time.deltaTime * animationSpeed;
		aniCount = (int)incTime;

		if (Open_Images.Length <= aniCount) 
		{
			Idle_On();
		}
	}


	public void Close_On()
	{
		MS = MoleState.Close;
		aniCount = 0;
		incTime = 0;
	}
	
	public void Close_Ing()
	{
		renderer.material.mainTexture = Close_Images [aniCount];	

		incTime += Time.deltaTime * animationSpeed;
		aniCount = (int)incTime;

		if (Close_Images.Length <= aniCount) 
		{
			StartCoroutine("Wait");
		}
	}

	
	public void Idle_On()
	{
		MS = MoleState.Idle;
		aniCount = 0;
		incTime = 0;
	}
	
	public void Idle_Ing()
	{
		renderer.material.mainTexture = Idle_Images [aniCount];	

		incTime += Time.deltaTime * animationSpeed;
		aniCount = (int)incTime;

		if (Idle_Images.Length <= aniCount) 
		{
			Close_On();
		}
	}


	
	public void Catch_On()
	{
		MS = MoleState.Catch;
		aniCount = 0;
		incTime = 0;
	}
	
	public void Catch_Ing()
	{
		renderer.material.mainTexture = Catch_Images [aniCount];

		incTime += Time.deltaTime * animationSpeed;
		aniCount = (int)incTime;
		
		if (Catch_Images.Length <= aniCount) 
		{

		}
	}

	public void None_On()
	{
		MS = MoleState.None;
		aniCount = 0;
		incTime = 0;
	}

	public IEnumerator Wait() 
	{
		MS = MoleState.None;
		aniCount = 0;
		incTime = 0;

		float wait_time = Random.Range (0.5f, 4.5f);
		yield return new WaitForSeconds (wait_time);
		Open_On ();
	}


	// Update is called once per frame
	void Update () {

		switch (MS) 
		{
		case MoleState.None: break;
		case MoleState.Open: Open_Ing(); break;
		case MoleState.Idle: Idle_Ing(); break;
		case MoleState.Close: Close_Ing(); break;
		}
	}
}
