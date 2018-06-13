using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonSpawnScript : MonoBehaviour {

	public GameObject balloon;
	private bool sleep;

	void awake()
	{
		sleep = false;
	}

	void Start () 
	{
		sleep = false;
	}

	void Update () 
	{
		if (!sleep) 
		{
			Vector3 vec = new Vector3 ();
			vec.x = Random.Range (-5.0f, 5.0f);
			vec.z = Random.Range (-2.0f, 2.0f);

			vec += transform.position;

			Instantiate (balloon, vec, Quaternion.identity);

			sleep = true;

			Invoke ("awake", Random.Range (0.75f, 2.0f));
		}
	}
}
