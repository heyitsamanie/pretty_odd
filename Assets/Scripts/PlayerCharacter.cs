using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{

    [SerializeField]
    private float acceleractionForce = 5;

    [SerializeField]
    private float maxSpeed = 5;

    [SerializeField]
    private Rigidbody2D rb2d;

    private float horizontalInput;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        horizontalInput = Input.GetAxis("Horizontal");

	}

    private void FixedUpdate() //make physics calls in fixed update 
    {

        rb2d.AddForce(Vector2.right * horizontalInput * acceleractionForce);

        Vector2 clampedVelocity = rb2d.velocity;
        clampedVelocity.x = Mathf.Clamp(rb2d.velocity.x, -maxSpeed, maxSpeed);
        rb2d.velocity = clampedVelocity;

    }

}
