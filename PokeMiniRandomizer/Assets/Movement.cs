﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public float speed;
	public float jumpForce;
	private float moveInput;
	public float floatPower;

	private Rigidbody2D rb;

	private bool isGrounded;
	public Transform groundCheck;
	public float checkRadius;
	public LayerMask whatIsGround;

	private int extraJumps;
	public int extraJumpValue;

	public Animator animator;
	
	private bool facingRight = true;
	
	private void Start()
	{
		extraJumps = extraJumpValue;
		rb = GetComponent<Rigidbody2D>();
	}

	private void FixedUpdate()
	{
		animator.SetFloat("Speed", Mathf.Abs(moveInput));
		
		isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
		
		moveInput = Input.GetAxisRaw("Horizontal");
		rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

		if (facingRight == false && moveInput > 0)
		{
			Flip();
		}
		else if (facingRight == true && moveInput < 0)
		{
			Flip();
		}
	
		if (Input.GetKey(KeyCode.W) && isGrounded == false) 
		{
    			rb.gravityScale = floatPower;
		}
		else
    			rb.gravityScale = 2;

	}

	private void Update()
	{
		if (isGrounded == true)
		{
			extraJumps = extraJumpValue;
			animator.SetBool("IsJumping", false);
		}

		
		if (Input.GetKeyDown(KeyCode.W) && extraJumps > 0)
		{
			rb.velocity = Vector2.up * jumpForce;
			extraJumps--;
			animator.SetBool("IsJumping", true);
		}else if (Input.GetKeyDown(KeyCode.W) && extraJumps == 0 && isGrounded == true)
		{
			rb.velocity = Vector2.up * jumpForce;
		}
	}

	void Flip()
	{
		facingRight = !facingRight;
		Vector3 Scaler = transform.localScale;
		Scaler.x *= -1;
		transform.localScale = Scaler;
	}
}
