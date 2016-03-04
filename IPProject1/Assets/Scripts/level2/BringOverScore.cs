﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BringOverScore : MonoBehaviour {

	public Text scoreText;
	public Text liveText;

	// Use this for initialization
	void Start () {
		GameObject gameData = GameObject.Find("GameData");
		if (gameData != null)
		{
			GameDataScript gameDataScript = gameData.GetComponent<GameDataScript>(); 
			scoreText.text = "Score:" + gameDataScript.score.ToString();
			liveText.text = "Lives: " + gameDataScript.lives;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
