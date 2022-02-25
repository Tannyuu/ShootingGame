using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TCameraController : MonoBehaviour
{
	public Transform player;

	public GameObject mainCamera;
	public GameObject subCamera;

	public Transform YAxis;
	public Transform XAxis;

	public float XSpeed = 1.0f;
	public float YSpeed = 1.0f;

	void Start()
	{
		
		mainCamera = GameObject.Find("Main Camera");
		subCamera = GameObject.Find("Sub Camera");

		subCamera.SetActive(false);
	}

    private void Update()
    {
		float xRotation = Input.GetAxis("Mouse X") * XSpeed;
		float yRotation = Input.GetAxis("Mouse Y") * YSpeed;
		YAxis.transform.Rotate(0, -xRotation, 0);
		XAxis.transform.Rotate(yRotation, 0, 0);
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
