using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEnemyController : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            //Debug.Log("Hit");

            animator.SetTrigger("damage");

            //Destroy(gameObject, 0.1f);
        }
        
    }
    public void OnDelete()
    {
        Destroy(gameObject, 0.1f);
    }
}
