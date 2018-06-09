using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEditor;
using UnityEngine;

public class GunBehavior : MonoBehaviour
{

	public Transform Barrel;
	public float Range = 0f;

	public float Delay = 0f;
	bool Fired;

	bool isAuto;
	public KeyCode SwitchFireMode;
	

	private void Update()
	{
		if (Input.GetButton("Fire1") && !Fired && isAuto)
		{
			Fired = true;
			StartCoroutine("FireAuto");
		}

		if (Input.GetButtonDown("Fire1") && !Fired && !isAuto)
		{
			Fired = true;
			StartCoroutine("FireSemi");
		}

		if (Input.GetKeyDown(SwitchFireMode))
		{
			if (!isAuto)
			{
				isAuto = true;
			}
			else
			{
				isAuto = false;
			}
		}
	}

	IEnumerator FireAuto ()
	{
		RaycastHit hit;
		Ray ray = new Ray(Barrel.position, transform.forward);

		if (Physics.Raycast(ray, out hit, Range))
		{
			if(hit.collider.tag == "Enemy")
			{
				EnemyBehavior enemy = hit.collider.GetComponent<EnemyBehavior>();
				enemy.EnemyHealth -= 1;
			}
		}

		Debug.DrawRay(Barrel.position, transform.forward * Range, Color.green);
		yield return new WaitForSeconds(Delay);
		Fired = false;
	}
	IEnumerator FireSemi ()
	{
		RaycastHit hit;
		Ray ray = new Ray(Barrel.position, transform.forward);

		if (Physics.Raycast(ray, out hit, Range))
		{
			if(hit.collider.tag == "Enemy")
			{
				EnemyBehavior enemy = hit.collider.GetComponent<EnemyBehavior>();
				enemy.EnemyHealth -= 1;
			}
		}

		Debug.DrawRay(Barrel.position, transform.forward * Range, Color.red);
		yield return null;
		Fired = false;
	}
}
