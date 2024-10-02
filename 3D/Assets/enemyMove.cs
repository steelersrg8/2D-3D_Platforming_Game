using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour {
	int time = 0;
	float positionChangeX = 0.0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		time++;
		positionChangeX = (float)time / 100.0f;
		if (time < 120) {
			transform.position = new Vector3 (transform.position.x - 0.1f, 17.89f, 0);
			transform.localScale = new Vector3 (1, 1, 1);
		} else if (time < 240) {
			transform.position = new Vector3 (transform.position.x + 0.1f, 17.89f, 0);
			transform.localScale = new Vector3 (-1, 1, 1);
		} else {
			time = 0;
		}

	}
}