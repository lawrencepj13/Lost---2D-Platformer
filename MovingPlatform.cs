using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovingPlatform : MonoBehaviour
{

	float moveSpeed = 3f;
	bool moveRight = true;

	public GameObject Player;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject == Player)
		{
			Player.transform.parent = transform;
		}

	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject == Player)
		{
			Player.transform.parent = null;
		}

	}

	// Update is called once per frame
	void Update()

	{
		if (transform.position.x > 68f)
			moveRight = false;
		if (transform.position.x < 62f)
			moveRight = true;

		if (moveRight)
			transform.position = new Vector3(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
		else
			transform.position = new Vector3(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
	}

	


}
