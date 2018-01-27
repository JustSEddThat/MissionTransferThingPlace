using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
	#region Enemy variables

	public Planet enemy;

	#endregion

	#region Player Variables

	public float health;

	#endregion

	public float radius;

	public GameObject virus;

	void Start ()
	{
		
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Z))
		{
			Shoot ();
		}
	}

	void FixedUpdate ()
	{
		

	}

	void Shoot ()
	{
		if (virus != null)
		{
			Vector3 loc = Random.insideUnitSphere * radius;
			GameObject shot = Instantiate (virus, loc, Quaternion.identity);

			if (shot.GetComponent<Virus> ())
			{
				shot.GetComponent<Virus> ().player = this;
			}
		}
	}

	public void TakeDamage (int dmg)
	{
		health -= dmg;
	}
}
