using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBulletSpawn : MonoBehaviour {

	public GameObject eBullet;

	int time = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		time++;

		if (time == 1) {
			GameObject g = (GameObject)Instantiate (eBullet, transform.position, Quaternion.identity);
			g.GetComponent<Rigidbody2D> ().velocity = new Vector2 (-6, 0);
			Physics2D.IgnoreCollision (g.GetComponent<Collider2D> (), transform.parent.GetComponent<Collider2D> ());
		
		} else if (time == 41) {
			GameObject g = (GameObject)Instantiate (eBullet, transform.position, Quaternion.identity);
			g.GetComponent<Rigidbody2D> ().velocity = new Vector2 (6, 0);
			Physics2D.IgnoreCollision (g.GetComponent<Collider2D> (), transform.parent.GetComponent<Collider2D> ());

		} else if (time == 80) {
			time = 0;
		}
	

	}
}
