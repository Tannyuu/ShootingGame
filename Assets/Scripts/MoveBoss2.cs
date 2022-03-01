using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveBoss2 : MonoBehaviour
{
    //private CharacterController enemyController;
    private Animator animator;


    public Transform player;
    //索敵範囲
    public float traceDist = 12.0f;
    NavMeshAgent nav;

    private bool arrived;
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        //毎フレーム距離の計測をする必要はないのでコルーチンで行う。
        StartCoroutine(CheckDist());

        animator = GetComponent<Animator>();

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
            if (dist < traceDist && dist > 2.7f)
            {
                //プレイヤーの位置を目的地に設定
                nav.SetDestination(player.position);
                //追跡再開
                nav.isStopped = false;
                animator.SetBool("IsWalk", true);

                animator.SetBool("IsAttack", false);

            }
            else if (dist <= 2.7f)
            {
                //探索範囲から出たら追跡終了
                nav.isStopped = true;
                if (!animator.GetCurrentAnimatorStateInfo(0).IsName("attack"))
                {
                    animator.SetBool("IsAttack", true);
                    animator.SetTrigger("attack");

                };

            }
        }
    }
}
