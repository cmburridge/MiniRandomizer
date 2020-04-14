using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{

	private SpriteRenderer rend;
	private Sprite basicBackground,
		mewtwoBackground,
		teamBackground,
		vsBackground,
		waterBackground,
		legendsBackground,
		charizardBackground; 
	
	// Use this for initialization
	void Start ()
	{
		rend = GetComponent<SpriteRenderer>();
		basicBackground = Resources.Load<Sprite>("Pokeball");
		teamBackground = Resources.Load<Sprite>("Team");
		vsBackground = Resources.Load<Sprite>("Vs");
		mewtwoBackground = Resources.Load<Sprite>("Mewtwo");
		waterBackground = Resources.Load<Sprite>("Water");
		legendsBackground = Resources.Load<Sprite>("Legends");
		charizardBackground = Resources.Load<Sprite>("Charizard");
		rend.sprite = basicBackground;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.B))
		{
			if (rend.sprite == basicBackground)
			{
				rend.sprite = teamBackground;
			}
			else if (rend.sprite == teamBackground)
			{
				rend.sprite = mewtwoBackground;
			}
			else if (rend.sprite == mewtwoBackground)
			{
				rend.sprite = vsBackground;
			}
			else if (rend.sprite == vsBackground)
			{
				rend.sprite = waterBackground;
			}
			else if (rend.sprite == waterBackground)
			{
				rend.sprite = legendsBackground;
			}
			else if (rend.sprite == legendsBackground)
			{
				rend.sprite = charizardBackground;
			}
			else if (rend.sprite == charizardBackground)
			{
				rend.sprite = basicBackground;
			}
		}
	}
}
