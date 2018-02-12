using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Samurai : MonoBehaviour
{
    // movement assets
    Rigidbody2D rigidbody2D;
    Vector2 position;
    int walkingForce = 300;
    float normalGravity = 10;
    float fallingGravity = 20;
    int jumpForce = 500;

	// Use this for initialization
	void Start ()
    {
        // setting movement assets
        rigidbody2D = GetComponent<Rigidbody2D>();
        position = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void FixedUpdate()
    {
        // what happens if the user pushes the movement keys
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            // takes the current x and adds the movement force to it
            rigidbody2D.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * walkingForce * Time.fixedDeltaTime, 0);
        }
        else
        {
            rigidbody2D.velocity = Vector2.zero;
        }

        // what happens if the user pushes the jump button
        if (Input.GetButtonDown("Jump"))
        {
            rigidbody2D.velocity = Vector2.up * jumpForce * Time.fixedDeltaTime;
        }
    }
}
