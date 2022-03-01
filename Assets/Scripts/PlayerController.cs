using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public int killCount=0;
    public int killBossCount=0;
    public int life=3;

    public LifePanel lp;

    const float StunDuration = 0.5f;
    float recoverTime = 0.0f;
    
   
    public int GetKillCount()
    {
        return killCount;
    }

    public int GetKillBossCount()
    {
        return killBossCount;
    }

    
    public void killEnemy(int n)
    {
        killCount += n;
    }

    public void killBoss(int n)
    {
        killBossCount += n;
    }

    bool IsStun()
    {
        return recoverTime > 0.0f || life <= 0;
    }

    private void OnControllerColliderHit(ControllerColliderHit other)
    {
        if (IsStun()) {
            return;
        }
        //Debug.Log("ok");
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "Mace")
        {
            //Debug.Break();
            Debug.Log("life" + life);
            life -= 1;
            lp.UpdateLife(life);
            recoverTime = StunDuration;
        }
    }

    public int Life()
    {
        return life;
    }

    public void LoadClear()
    {
        Invoke("GoToClear", 2.0f);
    }
    public void GoToClear()
    {
        SceneManager.LoadScene("Clear");
    }

    private void Update()
    {
        if (IsStun())
        {
            //動きを止め気絶状態からの復帰カウントを進める
            recoverTime -= Time.deltaTime;
        }
    }
}
