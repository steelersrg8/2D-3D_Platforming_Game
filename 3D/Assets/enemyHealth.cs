using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour {

	public int eHealth;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "bullet") {
			eHealth--;
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (eHealth <= 0) {
			Destroy (this.gameObject);
			GameManager.score++;
		}
	}
}
