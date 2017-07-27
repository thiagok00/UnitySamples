using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public int jumpForce;
	public int moveVelocity;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown("space")) {
			this.GetComponent<Rigidbody2D>().AddForce( new Vector2(0,jumpForce));
		}
		this.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveVelocity , this.GetComponent<Rigidbody2D>().velocity.y);
	}

	void OnTriggerEnter2D (Collider2D c)
	{
		Debug.Log (c.tag);
		if (c.tag == "Obstacle") {
			GameObject.Destroy(this.gameObject);
		}
	}
}
