using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBalloonScript : ParentBallonScript {

	private int thisScore;
	private const int scoreTimeMod = 2;


	public override void pop(bool shot)
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
	protected override void Start () 
	{
		base.Start ();

		thisScore = Mathf.FloorToInt( Random.Range (1.0f, 1.25f) * (100 + (scoreTimeMod * Time.time)) ); // total score has a base value of 100, plus an amount based on time and then a random variation for up to 50%

		GetComponentInChildren<TextMesh> ().text = thisScore.ToString();
	}
}