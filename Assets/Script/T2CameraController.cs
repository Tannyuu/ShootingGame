using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2CameraController : MonoBehaviour
{
    public Transform YAxis;
    public Transform XAxis;

    public float XSpeed = 1.0f;
    public float YSpeed = 1.0f;
    Quaternion rot;
    Transform Axis;

    private void Start()
    {
        //マウスカーソル消したければこのコメントアウトを外す
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
        rot = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        float xRotation= Input.GetAxis("Mouse X") * XSpeed;
        float yRotation= Input.GetAxis("Mouse Y") * YSpeed;
        YAxis.transform.Rotate(yRotation, -xRotation, 0);
        //XAxis.transform.Rotate(yRotation, 0, 0);
        //Axis.transform.rotation= YAxis.transform.rotation * XAxis.transform.rotation;
        YAxis.transform.rotation = YAxis.transform.rotation;
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            rot.z = 0;
            transform.rotation=rot;
        }
    }
}
