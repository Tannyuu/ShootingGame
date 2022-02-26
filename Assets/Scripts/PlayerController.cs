using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int killCount;
    public int bossKillCount;
    public int life;

    public int GetKillCount()
    {
        return killCount;
    }

    public int GetBossKillCount()
    {
        return bossKillCount;
    }

    /*
    public void enemyKill(Collision other)
    {
        if(other.OncollisionEnter.tag=="Enemy")
        {
            player.killCount += 1;
        
    }
    */

    public int Life()
    {
        return life;
    }
}
