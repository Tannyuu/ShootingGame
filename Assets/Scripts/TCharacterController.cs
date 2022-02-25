using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TCharacterController : MonoBehaviour
{
    Vector3 pos;
    public float rotSpeed = 300.0f;

    void Start()
    {
        pos = transform.position;
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
    }
}
