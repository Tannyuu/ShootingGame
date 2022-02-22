using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    Vector3 pos;
    void Start()
    {
        pos = transform.position;
    }
    void Update()
    {
        float leftRight = Input.GetAxis("Horizontal");
        float frontBack = Input.GetAxis("Vertical");
        pos.x += leftRight;
        pos.z += frontBack;
        transform.position = pos;
    }
}
