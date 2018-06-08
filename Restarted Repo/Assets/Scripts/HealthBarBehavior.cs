using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBehavior : MonoBehaviour
{

	public FloatData HealthLevel;
	public Image HealthImage;
	
	// Use this for initialization
	void Start ()
	{
		HealthImage.GetComponent<Image> ().color = Color.green ;
	}
	
	// Update is called once per frame
	void Update ()
	{
		HealthImage.fillAmount = HealthLevel.Value;
		if (HealthLevel.Value < 0.5)
			HealthImage.GetComponent<Image>().color = Color.yellow;
		
		if (HealthLevel.Value < 0.33)
			HealthImage.GetComponent<Image>().color = Color.red;

	}
}
