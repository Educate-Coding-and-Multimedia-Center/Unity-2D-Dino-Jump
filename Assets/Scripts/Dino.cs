using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dino : MonoBehaviour {

	public float jumpPower = 5f;
	public float moveSpeed = 10f;
	Rigidbody2D body;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space)) {
			Vector2 force = new Vector2(0, jumpPower);
			body.velocity = force;
		}
		if (Input.GetKey(KeyCode.A)) {
			Vector2 force = new Vector2(-moveSpeed, body.velocity.y);
			body.velocity = force;
		}
		if (Input.GetKey(KeyCode.D)) {
			Vector2 force = new Vector2(moveSpeed, body.velocity.y);
			body.velocity = force;
		}
	}
}
