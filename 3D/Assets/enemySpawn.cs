using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour {

	public GameObject enemy1;
	bool enemyOn = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (GameManager.score == 10) {
			if (enemyOn == false) {
				GameObject enemyNew = (GameObject)Instantiate (enemy1, new Vector3 (38.0f, 17.89f, 0), Quaternion.identity);
				enemyOn = true;
			}
		}
		
	}
}
