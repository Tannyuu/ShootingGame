using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TBulletController : MonoBehaviour
{
    void OnBecameInvisible()
    {
        Destroy(gameObject);        
    }
}
