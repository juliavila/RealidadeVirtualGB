using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentBallonScript : MonoBehaviour {

	public float speed = 20.0f; // speed of ascent
	public float angle = 0.0f; // angle to give a more natural movement, in degrees

	public void pop(bool shot)
	{
		if (shot) 
		{
			
		} 
		else 
		{
			
		}
		Destroy (gameObject);
	}

	void Start () 
	{
		GetComponent<Rigidbody> ().useGravity = false;
		GetComponent<Rigidbody> ().interpolation = RigidbodyInterpolation.Interpolate;

		GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

		tag = "Balloon";
	}

	void Update () 
	{
		Rigidbody controller = GetComponent<Rigidbody>();

		Vector3 position = controller.position;

		Vector3 movement = Vector3.up;
		angle += Random.value * 2.0f; // increases angle based on a random number
		movement.x = Mathf.Cos (angle*Mathf.Deg2Rad); // convert to radians
		movement *= (speed*Time.deltaTime); // adjust with time

		controller.MovePosition (position + movement);
	}
}