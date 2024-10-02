using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {

		if (other.gameObject.tag == "Player") {

			if (playerItem.hasKey) {
                other.gameObject.transform.position = new Vector3 ( 2.5f, 7, 0);
			} else {
				GameManager.msg = "No key! Find a key first!";
				Invoke ("resetMsg", 2.0f);
			}
		}

	}

	void resetMsg() {
		GameManager.msg = "";
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
