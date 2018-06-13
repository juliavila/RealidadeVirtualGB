using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public static int score = 0;
	public bool sleep = false;



	void awake()
	{
		sleep = false;
	}

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (!sleep) 
		{
			string s = "Score: " + score;

			Debug.Log (s);

			Invoke ("awake", 5.0f);

			sleep = true;
		}
	}
}
