using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CameraController : MonoBehaviour
{

	public GameObject player;

	private Vector3 offset;
	// Use this for initialization
	void Start ()
	{
		offset = transform.position - player.transform.position;
	}
	
	void LateUpdate ()	// Runs after all items have been processed in Update.
						// Ensures the player has already moved for that frame.
	{
		transform.position = player.transform.position + offset;
	}
}
