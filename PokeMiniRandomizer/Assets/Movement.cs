using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	
	public Transform player;
	public float speed;
	public float jumpHeight; 
	
	void Update () {
		
		if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(player.TransformDirection(Vector3.right * speed));
		}
		if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(player.TransformDirection(Vector3.left * speed));
		}
		if (Input.GetButtonDown("Jump"))
		{
			transform.Translate(player.TransformDirection(Vector3.up * jumpHeight));
		}
	}
}
