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

    private void OnCollisionEnter(Collision other)
    { 
        if (other.gameObject.tag == "Enemy")
        {
            
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
