﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupPoints : MonoBehaviour {

	public int scoreToGive;
	private ScoreManager theScoreManager;
	public AudioSource eatSound;

	// Use this for initialization
	void Start () {
		theScoreManager = FindObjectOfType<ScoreManager> ();
	}
		
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.name == "Player") {
			theScoreManager.AddScore (scoreToGive);
			eatSound.enabled = true;
			eatSound.Play ();
			gameObject.SetActive (false);
		}
	}
}
