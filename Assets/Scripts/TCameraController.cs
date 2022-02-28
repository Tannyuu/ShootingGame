using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TCameraController : MonoBehaviour
{
	public Transform player;

	public GameObject mainCamera;
	public GameObject subCamera;

	void Start()
	{
		
		mainCamera = GameObject.Find("Main Camera");
		subCamera = GameObject.Find("SubCamera");

		subCamera.SetActive(false);
	}

	void LateUpdate()
	{
		mainCamera.transform.position = player.position + (-player.forward * 3.0f) + (player.up * 1.0f);
		mainCamera.transform.LookAt(player.position + Vector3.up);

        if (Input.GetMouseButtonDown(1))
        {
			mainCamera.SetActive(!mainCamera.activeSelf);
			subCamera.SetActive(!subCamera.activeSelf);
        }
	}
}
