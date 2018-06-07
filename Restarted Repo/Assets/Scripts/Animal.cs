using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]

public class Animal : ScriptableObject
{

	public float Health = 1.0f;
	public float Speed = 1.0f;
	public float Strength = 1.0f;
	public float LegCount = 2.0f;

	public PowerUpBase PowerUp;

	public void UpdateHealth()
	{
		Health += PowerUp.PowerLevel;
		
	}
	
	

}
