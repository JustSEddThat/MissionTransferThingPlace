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
		Vector3 pos = Vector3.MoveTowards (player.transform.position,player.enemy.transform.position, 100f);

		transform.position += Vector3.Lerp (player.transform.position, pos, 0.005f);
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject != player)
		{
			if (other.gameObject == enemy)
			{
				enemy.TakeDamage (dmg);
			}
		}
	}

	void CalculateRotation()
	{
		Vector3 dir = player.enemy.gameObject.transform.position - player.gameObject.transform.position;
		dir.Normalize ();

		float rotateAmtX = Vector3.Cross (dir, transform.right).x;
		float rotateAmtY = Vector3.Cross (dir, transform.up).y;
		float rotateAmtZ = Vector3.Cross (dir, transform.forward).z;

		Vector3 rotationAmt = new Vector3 (rotateAmtX, rotateAmtY, rotateAmtZ);

		rb.angularVelocity = rotationAmt * rotateSpeed;

		rb.velocity = transform.forward * speed;

	}
}
