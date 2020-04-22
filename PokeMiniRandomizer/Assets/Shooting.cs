using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

	public GameObject bulletPrefab;
	public Transform firePos;
	
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			Instantiate(bulletPrefab, transform.position, Quaternion.identity);
		}
	}
}
