using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static string msg = "";
	public static int score = 0;
	public static float pHealth = 100;
	public static int healthTimer = 0;
	public static int money = 0;

	void OnGUI() {

		GUI.Label (new Rect (40, 40, 200, 40), msg);
		GUI.Label (new Rect (40, 80, 200, 40), "Score: " + score);
		GUI.Label (new Rect (40, 120, 200, 40), "Health: " + pHealth);
		GUI.Label (new Rect (40, 160, 200, 40), "Money: " + money);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		healthTimer++;

		pHealth = pHealth - (float)healthTimer * 0.0001f;

	}
}
