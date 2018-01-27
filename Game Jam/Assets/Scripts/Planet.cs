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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> parent of b9040dc... bang bang
=======
>>>>>>> parent of b9040dc... bang bang
	[Range(1,6)]
	public int diseaseLevel;
	[Range(0,7)]
	public int resources;

	private float builtPower;
=======
>>>>>>> parent of e5f3a5c... Resources logic

<<<<<<< HEAD
	#endregion

<<<<<<< HEAD
=======
	#endregion

>>>>>>> parent of df95285... Planet script added
=======
	public float radius;

>>>>>>> parent of b9040dc... bang bang
=======
	#endregion

	public float radius;

>>>>>>> parent of b9040dc... bang bang
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

<<<<<<< HEAD
	public void BuildDisease(int diseaseLvl)
	{
		builtPower += ConvertDLToPower(diseaseLvl);

		resources -= diseaseLvl;

	}


=======
>>>>>>> parent of e5f3a5c... Resources logic
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

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
	public void TakeDamage (float dmg)
=======
	public void TakeDamage(int dmg)
>>>>>>> parent of df95285... Planet script added
=======
	public void TakeDamage(int dmg)
>>>>>>> parent of df95285... Planet script added
=======
	public void TakeDamage (float dmg)
>>>>>>> parent of b9040dc... bang bang
=======
	public void TakeDamage (float dmg)
>>>>>>> parent of b9040dc... bang bang
=======
	public void TakeDamage (int dmg)
>>>>>>> parent of e5f3a5c... Resources logic
	{
		health -= dmg;
	}
}
