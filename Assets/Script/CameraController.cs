using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public Transform player;

	public GameObject mainCamera;
	public GameObject subCamera;

	void Start()
	{
		
		mainCamera = GameObject.Find("Main Camera");
		subCamera = GameObject.Find("Sub Camera");

		subCamera.SetActive(false);
	}

	void LateUpdate()
	{
		transform.position = player.position + (-player.forward * 3.0f) + (player.up * 1.0f);
		transform.LookAt(player.position + Vector3.up);

        if (Input.GetKeyDown(KeyCode.Space))
        {
			//mainCamera.SetActive(!mainCamera.activeSelf);
			subCamera.SetActive(!subCamera.activeSelf);
        }
	}
}
