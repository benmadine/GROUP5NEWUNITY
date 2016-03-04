﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/*This class manages the persistant data while the game is being played.
 * The methods are called by other classes to modify the score and lives
 * depending on the situation*/
public class score : MonoBehaviour {

	// These variables will store the players score and lives
	public Text scoreText;
	public int playerScore = 0;
	public Text liveText;
	public int playerLives = 3;

	void Start()
	{

	}

	void Update()
	{
		GameObject gameData = GameObject.Find("GameData");
		if (gameData != null)
		{
			GameDataScript gameDataScript = gameData.GetComponent<GameDataScript>(); 
			scoreText.text = "Score:" + gameDataScript.score.ToString();
			liveText.text = "Lives: " + gameDataScript.lives;
			gameDataScript.score = playerScore;
			gameDataScript.lives = playerLives;
		}
		if (playerLives == 0) 
		{
			Application.LoadLevel("EndScene");
		}
	}

	// This method is called by other classes. An integer is passed in which changes the score
	public void ModifyScore(int value)
	{
		// The int value is added to playerScore. If it is negative it lowers the score
		playerScore += value;
	}
	
	/*This method is called by other classes to modify the lives. An integer is passed in to
	 * increase or decrease the lives*/
	public void ModifyLives(int value)
	{
		/*The int value is used to increase or decrease the lives depending on whether it is
		 * positive or nagative*/
		playerLives += value;
	}
}

