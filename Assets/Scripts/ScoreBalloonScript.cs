using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBalloonScript : MonoBehaviour {

	private int thisScore;
	private const int scoreTimeMod = 20;


	public void pop(bool shot)
	{
		if (shot) 
		{
			Player.score += thisScore;
		} 
		else 
		{
			Player.score -= thisScore / 4;
		}
		Destroy (gameObject);
	}

	// Use this for initialization
	void Start () 
	{
		
		thisScore = Mathf.FloorToInt( Random.Range (1.0f, 1.5f) * (100 + (scoreTimeMod * Time.time)) ); // total score has a base value of 100, plus an amount based on time and then a random variation for up to 50%
	}

	void Update()
	{
		
	}

	void OnMouseOver()
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			pop (true);
		}
	}
}