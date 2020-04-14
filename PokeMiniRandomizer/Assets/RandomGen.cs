using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomGen : MonoBehaviour {

	public GameObject[] objects;
	public bool spawned = false;
	
	
	public void Roll()
	{
		if (spawned == false)
		{
			int rand = Random.Range(0, objects.Length);
			Instantiate(objects[rand], transform.position, Quaternion.identity);
			spawned = true;
		}
	}

	public void Clear()
	{
		if (spawned == true)
		{
			Destroy(GameObject.FindGameObjectWithTag("Player"));
			spawned = false;
		}
	}

}
