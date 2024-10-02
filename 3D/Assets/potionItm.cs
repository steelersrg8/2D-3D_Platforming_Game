using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potionItm : MonoBehaviour {

	GameObject myPlayer;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			Destroy (this.gameObject);

			//other.gameObject.transform.localScale = new Vector3 (2.5f, 2.5f, 1);
			myPlayer.SendMessage("getBigger");
			GameManager.msg = "Congrats! You found a potion!";
			Invoke ("resetMsg3", 2.0f);
		}
	}

	void resetMsg3() {
		GameManager.msg = "";
	}

	// Use this for initialization
	void Start () {
		myPlayer = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
