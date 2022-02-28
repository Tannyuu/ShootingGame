using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public int killCount=0;
    public int killBossCount=0;
    public int life=3;
    
   
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

    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Enemy" || other.gameObject.tag=="Boss" )
        {
            life -= 1;
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
}
