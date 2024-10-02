using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerItem : MonoBehaviour {

	public static bool hasKey = false;
	public static int money = 0;
	public static int health = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


	}

	void getBigger(){
		transform.localScale = new Vector3 (2.5f, 2.5f, 1);
		Invoke ("resetSize", 5.0f);
	}

	void resetSize() {
		transform.localScale = new Vector3 (1.77f, 1.77f, 1);
	}
}
