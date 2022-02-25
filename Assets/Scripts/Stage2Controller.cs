using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Stage2Controller : MonoBehaviour
{
    public PlayerController player;
    public LifePanel lifePanel;
   
    public void Update()
    {
        //ライフパネルを更新
        lifePanel.UpdateLife(player.Life());

        //プレイヤーのライフが０になったらゲームオーバー
        if (player.Life() <= 0)
        {
            //これ以降のUpdateは止める
            enabled = false;

            //2秒後にReturnToStage2を呼び出す
            Invoke("ReturnToStage2", 2.0f);

        }

        if (player.GetBossKillCount() == 1)
        {
            Invoke("MoveToClear", 2.0f);
        }

    }

    void ReturnToStage2()
    {
        //タイトルシーンに切り替え
        SceneManager.LoadScene("Stage2");
    }

    void MoveToClear()
    {
        //stage2に切り替え
        SceneManager.LoadScene("Clear");

        //2秒後にReturnToTitleを呼び出す
        Invoke("ReturnToTitle", 2.0f);
    }

    void ReturnToTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }
}

