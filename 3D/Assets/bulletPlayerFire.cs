using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletPlayerFire : MonoBehaviour {

	public GameObject pBullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.X) & UnityStandardAssets._2D.PlatformerCharacter2D.m_FacingRight == true)
        {
            GameObject g = (GameObject)Instantiate(pBullet, new Vector3(transform.position.x + 1, transform.position.y, 0), Quaternion.identity);
            g.GetComponent<Rigidbody2D>().velocity = new Vector2(3, 0);
        }
            //if facingRight == true
        else if(Input.GetKeyDown(KeyCode.X) & UnityStandardAssets._2D.PlatformerCharacter2D.m_FacingRight == false) {
            GameObject g = (GameObject)Instantiate(pBullet, new Vector3(transform.position.x - 1, transform.position.y, 0), Quaternion.identity);

			g.GetComponent<Rigidbody2D> ().velocity = new Vector2 (-3, 0);
		}

			//if facingRight == false, we have to flip the bullet or give - speed

			//Physics2D.IgnoreCollision (g.GetComponent<Collider2D> (), transform.parent.GetComponent<Collider2D> ());
		}
		
	}

