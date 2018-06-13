using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Balloon") 
		{
			col.gameObject.GetComponent<ParentBallonScript> ().pop (false);
		}
	}
}
