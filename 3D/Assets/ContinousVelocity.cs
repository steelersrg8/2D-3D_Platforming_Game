using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinousVelocity : MonoBehaviour {

	public Vector2 bSpeed;
    bool amispawned = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(!amispawned){

            if (UnityStandardAssets._2D.PlatformerCharacter2D.m_FacingRight == true)
                GetComponent<Rigidbody2D>().velocity = bSpeed;
            else
            {
                GetComponent<Rigidbody2D>().velocity = -bSpeed;
            }
            amispawned = true;
        }

		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
    }
}
