﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthItemScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {

		if (other.gameObject.tag == "Player") {
			GameManager.pHealth = 100.0f;
		}
        else if(other.gameObject.tag == "bullet"){
            GameManager.score++;
        }

		Destroy (this.gameObject);

	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
