﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public float scoreCount;
	public Text scoreText;
	public float pointsPerSecond;
	public bool scoreIncreasing;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (scoreIncreasing) {
			scoreCount += pointsPerSecond * Time.deltaTime;
		}
		scoreText.text = "Score: " + Mathf.Round(scoreCount) + "0";
	}
	public void AddScore(int pointsToAdd){
		scoreCount += pointsToAdd;
	}
}
