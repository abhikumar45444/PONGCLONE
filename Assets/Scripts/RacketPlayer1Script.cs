using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketPlayer1Script: MonoBehaviour {

    public float movementSpeed = 300f;
   [HideInInspector] public Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float dirY = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(0f, dirY) * movementSpeed;
    }

}
