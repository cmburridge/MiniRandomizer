using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomGen : MonoBehaviour {

	public GameObject[] objects;
	
	
	
	public void Roll()
	{
		int rand = Random.Range(0, objects.Length);
		Instantiate(objects[rand], transform.position, Quaternion.identity);
	}

	public void Clear(string tag)
	{
		GameObject[] gameObjects = GameObject.FindGameObjectsWithTag(tag);
		foreach (GameObject target in gameObjects)
		{
			GameObject.Destroy(target);
		}
	}

}
