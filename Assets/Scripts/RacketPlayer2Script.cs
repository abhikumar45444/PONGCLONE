using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketPlayer2Script : MonoBehaviour {

	public float movementSpeed = 300f;
	[HideInInspector] public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float dirY = Input.GetAxisRaw("Vertical2");
		rb.velocity = new Vector2(0f, dirY) * movementSpeed;
	}
}
