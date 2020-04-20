using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

	public float health = 5f;
	public GameObject player;
	public void OnTriggerEnter2D(Collider2D other)
	{
		health -= 1;
	}

	void Update () {
		if (health <= 0)
		{
			Destroy(player);
		}
	}
}
