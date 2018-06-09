using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{

	public int EnemyHealth;

	private void Update()
	{
		Debug.Log(EnemyHealth.ToString());
		if (EnemyHealth <= 0)
		{
			Destroy(gameObject);
		}
	}
}
