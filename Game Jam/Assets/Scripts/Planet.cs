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
	[Range(1,6)]
	public int diseaseLevel;
	[Range(0,7)]
	public int resources;

	private float builtPower;

=======
>>>>>>> parent of df95285... Planet script added
	#endregion

	public GameObject virus;

	void Start ()
	{
		builtPower = 0;
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

	public void BuildDisease(int diseaseLvl)
	{
		builtPower += ConvertDLToPower(diseaseLvl);

		resources -= diseaseLvl;

	}


	void Shoot ()
	{
		if (virus != null)
		{
			GameObject shot = Instantiate (virus, Vector3.zero, Quaternion.identity);
			if (shot.GetComponent<Virus> ())
			{
				shot.GetComponent<Virus> ().player = this;
				//virus damage should be equal to the combined damage values of the chosen DiseaseLevels
				shot.GetComponent<Virus> ().dmg = builtPower;
			}
		}

		//reset built power after shooting projectile;
		builtPower = 0;
	}

	float ConvertDLToPower(int lvl)
	{
		switch (lvl) 
		{
		case 1:
			return 50;

		case 2:
			return 100;

		case 3:
			return 200;

		case 4:
			return 350;

		case 5: 
			return 500;

		case 6:
			return 1000;

		default:
			Debug.Log ("some shit wrong bro");
			return 3;

		}
	}

<<<<<<< HEAD
	public void TakeDamage (float dmg)
=======
	public void TakeDamage(int dmg)
>>>>>>> parent of df95285... Planet script added
	{
		health -= dmg;
	}
}
