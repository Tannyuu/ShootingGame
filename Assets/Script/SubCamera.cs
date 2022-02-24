using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubCamera : MonoBehaviour
{
	public Transform player;

	public GameObject mainCamera;
	public GameObject subCamera;

	

	void LateUpdate()
	{
		//transform.position = player.position + (-player.forward * 3.0f) + (player.up * 1.0f);
		transform.LookAt(player.position);

		
	}
}
