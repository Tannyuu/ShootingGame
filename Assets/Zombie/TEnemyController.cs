using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TEnemyController : MonoBehaviour
{
    Animator animator;
    public Transform player;
    public float traceDist = 10.0f;
    NavMeshAgent nav;
    private bool arrived;

    void Start()
    {
        animator = GetComponent<Animator>();
        nav = GetComponent<NavMeshAgent>();
        StartCoroutine(CheckDist());
        arrived = false;
    }

    IEnumerator CheckDist()
    {
        while (true)
        {

            //1秒間に5回距離を計測する。
            yield return new WaitForSeconds(0.2f);
            //プレイヤーとの距離を計測
            float dist = Vector3.Distance(player.position, transform.position);
            //Debug.Log(dist);
            //索敵範囲に入ったか？
            if (dist < traceDist)
            {
                //プレイヤーの位置を目的地に設定
                nav.SetDestination(player.position);
                //追跡再開
                nav.isStopped = false;
                animator.SetBool("IsWalk", true);

                //animator.SetBool("IsAttack", false);

            }
            else if (dist <= 2.7f )
            {
                //探索範囲から出たら追跡終了
                nav.isStopped = true;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            //Debug.Log("Hit");
            nav.speed = 0f; //当たったら動きを止める;
            animator.SetTrigger("Damage");
            GetComponent<CapsuleCollider>().enabled = false;//当たったら当たり判定をオフにする
            //Destroy(gameObject, 0.1f);
        }
    }
    public void OnDelete()
    {
        Destroy(gameObject, 0.1f);
    }
}
