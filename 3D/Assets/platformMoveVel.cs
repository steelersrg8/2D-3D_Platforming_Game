using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMoveVel : MonoBehaviour {

	int time = 0;
	public float speed = 1.0f;
	public int intervalMove = 50;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		time++;

		if (time < intervalMove) {
			var vel = GetComponent<Rigidbody2D> ().velocity;
			vel.x = speed;
			GetComponent<Rigidbody2D> ().velocity = vel;
		} else if (time < 2*intervalMove) {
			var vel = GetComponent<Rigidbody2D> ().velocity;
			vel.x = -1 * speed;
			GetComponent<Rigidbody2D> ().velocity = vel;
		} else {
			time = 0;
		}

	}
}
