﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AnimalBehaviors : MonoBehaviour
{

	public Animal AnimalInfo;

	// Use this for initialization
	void Start () {
		print(AnimalInfo.Health);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
