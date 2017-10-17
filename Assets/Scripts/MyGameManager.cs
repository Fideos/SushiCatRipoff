using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyGameManager : MonoBehaviour
{
	public static MyGameManager instance;

	public Text scoreText;

	private int score = 0;

	void Awake()
	{
		if (instance == null)
			instance = this;
		else
			Destroy(this.gameObject);
	}

	public void AddScore(int scoreToAdd)
	{
		score += scoreToAdd;
		Debug.Log("NEW SCORE = " + score);
		scoreText.text = "SCORE: " + score;
	}
}
