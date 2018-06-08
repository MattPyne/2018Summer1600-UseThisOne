using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBehavior : MonoBehaviour
{

	public float HealthLevel = 1.0f;
	private Image HealthImage;
	
	// Use this for initialization
	void Start ()
	{
		HealthImage = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		HealthImage.fillAmount = HealthLevel;
	}
}
