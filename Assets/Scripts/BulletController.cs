using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    //public float speed;
    //public float destroyTime;
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    /*
     void Start () {
        Destroy(gameObject, destroyTime);
    }
    
    void Update () {
        transform.position += transform.forward * Time.deltaTime * speed;
    }
     */
}
