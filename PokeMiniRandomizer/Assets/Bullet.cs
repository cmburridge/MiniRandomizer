using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	
	public Transform bulletPrefab;
	public float velocity;
	private void Start()
	{
		StartCoroutine(BulletLife());
	}

	private void Update()
	{
		transform.Translate(bulletPrefab.TransformDirection(Vector3.left * velocity));
	}

	private IEnumerator BulletLife ()
	{
		yield return new WaitForSeconds(1f);
		Destroy(gameObject);
	}
}

