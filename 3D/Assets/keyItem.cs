using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyItem : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			Destroy (this.gameObject);
			//change the state of player: now player has a key
			playerItem.hasKey = true;
			GameManager.msg = "Congrats! You found a key!";
			Invoke ("resetMsg2", 2.0f);
		}
	}

	void resetMsg2() {
		GameManager.msg = "";
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
