using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TCharacterController : MonoBehaviour
{
    Vector3 pos;
    Quaternion rot;
    public float rotSpeed = 300.0f;

    void Start()
    {
        pos = transform.position;
        rot = transform.rotation;
    }
    void Update()
    {
        //float frontBack = Mathf.Max(Input.GetAxis("Vertical"), 0f);

        float leftRight = Input.GetAxis("Horizontal");
        float frontBack = Input.GetAxis("Vertical");
        pos.x += leftRight;
        pos.z += frontBack;
        //transform.Rotate(0, leftRight * rotSpeed * Time.deltaTime, 0);

        transform.position = pos;
        /*
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //Quaternion rot = new Quaternion(0f, 90f, 0f, 0f);
            rot.y += 45;
            transform.rotation = Quaternion.Euler(0f, rot.y, 0f);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //Quaternion rot = new Quaternion(0f, -90f, 0f, 0f);
            rot.y -= 45;
            transform.rotation = Quaternion.Euler(0f, rot.y, 0f);
        }
        */
    }
}
