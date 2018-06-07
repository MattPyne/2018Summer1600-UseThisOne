using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AnimalBehaviors : MonoBehaviour
{

	public Animal AnimalInfo;

	void OnTriggerEnter()
	{
		AnimalInfo.UpdateHealth();
		print(AnimalInfo.Health);
	}
}
