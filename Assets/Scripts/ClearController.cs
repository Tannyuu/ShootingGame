using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClearController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //2秒後にReturnToTitleを呼び出す
        Invoke("ReturnToTitle", 2.0f);
    }
    void ReturnToTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
