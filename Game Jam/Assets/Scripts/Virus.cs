using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virus : MonoBehaviour
{

	public Planet player;

	public Planet enemy;

	public Rigidbody rb;

	public float rotateSpeed;

	public float speed;

	public float dmg;

	void Start ()
	{
		enemy = player.enemy;
	}

	void LateUpdate ()
	{
		//MoveToTarget ();
		MoveToTargetRotation ();
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject != player.gameObject)
		{
			enemy.TakeDamage (dmg);
			Destroy (this.gameObject);

		}
	}

	void MoveToTarget()
	{
		Debug.Log ("Move to target");

		Vector3 pos = Vector3.MoveTowards (player.transform.position, player.enemy.transform.position, 100f);

		transform.position += Vector3.Lerp (player.transform.position, pos, 0.005f);
	}

	void MoveToTargetRotation ()
	{
		Debug.Log ("Move to target rotation");
		Vector3 dir = player.enemy.gameObject.transform.position - player.gameObject.transform.position;
		dir.Normalize ();

		Vector3 rotateAmt = Vector3.Cross (dir, enemy.gameObject.transform.position);

		rb.angularVelocity = -rotateAmt * rotateSpeed;

		rb.velocity = transform.forward * speed;

	}
}
