using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Stage1Controller : MonoBehaviour
{
    public PlayerController player;
    public LifePanel lifePanel;
    public GameObject killCount; 
    public void Update()
    {
        //ライフパネルを更新
        lifePanel.UpdateLife(player.Life());
        
        //プレイヤーのライフが０になったらゲームオーバー
        if (player.Life() <= 0)
        {
            //これ以降のUpdateは止める
            enabled = false;

            //2秒後にReturnToStage1を呼び出す
            Invoke("ReturnToStage1", 2.0f);
         
        }

        if (player.GetKillCount() == 20)
        {
            Invoke("MoveToStage2", 2.0f);
        }

    }

    void ReturnToStage1()
    {
        //タイトルシーンに切り替え
        SceneManager.LoadScene("Stage1");
    }

    void MoveToStage2()
    {
        //stage2に切り替え
        SceneManager.LoadScene("Stage2");
    }
}
